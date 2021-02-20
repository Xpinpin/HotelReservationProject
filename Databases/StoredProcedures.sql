USE HotelReservation_N_Tier;
GO
CREATE OR ALTER PROC spGetPassword 
	@Username VARCHAR(255)
AS
BEGIN
	SELECT Password FROM Login WHERE Username = @username;

END
GO
EXEC spGetPassword 'nguyenpham';
GO
CREATE OR ALTER PROC spGetClerkId
	@Username VARCHAR(255)
AS
BEGIN
	SELECT ClerkID FROM Login INNER JOIN Clerk ON Clerk.LoginId = Login.LoginId WHERE Login.Username = @Username;
END
GO
EXEC spGetClerkId 'nguyenpham';
GO
CREATE OR ALTER PROC spGetRoomName
AS
BEGIN

	SELECT Room.RoomId,RoomName FROM Room;

END
GO
CREATE OR ALTER PROC spGetRoomDetails
	@RoomId INT
AS
BEGIN
	SELECT RoomId, RoomNumber,RoomName, BedType.NumberOfBeds, MaximumOccupancy, BaseRate, RoomType.TypeDesc FROM Room
		INNER JOIN BedType ON BedType.BedTypeID = Room.BedTypeID
		INNER JOIN RoomType ON RoomType.RoomTypeID = Room.RoomTypeID
		WHERE RoomId = @RoomId;

END

GO
CREATE OR ALTER PROC spGetProvinceName
	@CountryId INT 
AS
BEGIN
	SELECT ProvinceId,ProvinceName FROM Province WHERE CountryId = @CountryId;
END
GO
EXEC spGetProvinceName 2;
GO
EXEC spGetRoomName

GO
CREATE OR ALTER PROC spCreateReservation
	@FirstName CHAR(30),
	@MiddleName CHAR(30),
	@LastName CHAR(30),
	@StreetAddress CHAR(30),
	@City CHAR(20),
	@PostalCode CHAR(7),
	@HomePhone CHAR(15),
	@CellPhone CHAR(15),
	@Email CHAR(35),
	@DateOfBirth DATE,
	@ProvinceId INT,
	@CountryId INT,

	@LastReservationNumber CHAR(8),
	@CheckInDate DATE,
	@CheckOutDate DATE,
	@AdultNumber SMALLINT,
	@ChildNumber SMALLINT,
	@CreationDate DATE,
	@ClerkId INT,
	@RoomId INT
AS
BEGIN
BEGIN TRY
	DECLARE @currentDate DATE,
			@ReservationNumber CHAR(12),

			@RoomCapacity INT,
			@GuestId INT,
			@BaseRate MONEY,
			@AdultBase MONEY,
			@ChildBase MONEY,
			@AdultRate MONEY,
			@ChildRate MONEY,
			@Total MONEY;

	SET @currentDate = (SELECT GETDATE());
	SET @RoomCapacity = (SELECT MaximumOccupancy FROM Room WHERE RoomId = @RoomId);
	SET @BaseRate = (SELECT BaseRate FROM Room WHERE RoomId = @RoomId);
	
	IF(@AdultNumber <= 0)
		THROW 51000,'There must be an adult to create the reservation.',1;
		

	IF(@AdultNumber = 1)
		BEGIN
			SET @AdultRate = 
			(Select GuestRate FROM GuestFee WHERE GuestType = 'Adult' AND @CreationDate > EffectiveDate) * 0;
		END
	ELSE
		BEGIN
			SET @AdultRate = 
			(Select GuestRate FROM GuestFee WHERE GuestType = 'Adult' AND @CreationDate > EffectiveDate) * (@AdultNumber - 1);
		END

	SET @ChildRate = 
		(SELECT GuestRate FROM GuestFee WHERE GuestType = 'Child' AND @CreationDate > EffectiveDate) * @ChildNumber;
	
	

	SET @Total = @BaseRate + @AdultRate + @ChildRate;

	
	IF(@CellPhone LIKE '' AND @HomePhone LIKE '')
		THROW 51000, 'A phone number is required.',1;
	

	
	IF((SELECT DATEDIFF(YEAR, @DateOfBirth, @currentDate)) < 19)
		THROW 51000, 'This person needs to be in the legal age to become a guest.',1;
	IF(@AdultNumber + @ChildNumber > @RoomCapacity)
		THROW 51000, 'The number of people exceeds the room capacity. Please try again.',1;
	

	INSERT INTO Guest (FirstName,MiddleName,LastName,StreetAddress,City,PostalCode,HomePhone,
						CellPhone,Email,DateOfBirth,CountryId,ProvinceId)
	VALUES
		(TRIM(@FirstName),TRIM(@MiddleName),TRIM(@LastName),@StreetAddress,@City,@PostalCode,@HomePhone,
			@CellPhone,@Email,@DateOfBirth,@CountryId,@ProvinceId)

	SET @GuestId = (SELECT GuestId FROM Guest WHERE FirstName = @FirstName AND LastName = @LastName);
	SET @ReservationNumber = (
		(SELECT SUBSTRING(FirstName,1,1) +  SUBSTRING(LastName,1,1) FROM Clerk WHERE ClerkID = @ClerkID)
		+ (SELECT SUBSTRING(FirstName,1,1) +  SUBSTRING(LastName,1,1) FROM Guest WHERE GuestId = @GuestId)
		+ @LastReservationNumber
		)
	IF((SELECT COUNT(*) FROM Reservation WHERE ReservationNumber = @ReservationNumber) = 1)
		THROW 51000, 'The reservation has already existsed, please create a new one.',1;

	INSERT INTO Reservation (ReservationNumber, CheckInDate, CheckOutDate, AdultNumber, ChildNumber,
							BaseRate, AdultRate, ChildRate,Total, CreationDate, ClerkId, GuestId, RoomId)
	VALUES
		(@ReservationNumber,@CheckInDate,@CheckOutDate,@AdultNumber,@ChildNumber,
		@BaseRate,@AdultRate,@ChildRate,@Total,@CreationDate,@ClerkId,@GuestId,@RoomId)
END TRY
BEGIN CATCH
	;THROW

END CATCH


END
GO

CREATE OR ALTER PROC spGetClerkInitial
	@ClerkID INT
AS
BEGIN 
	SELECT SUBSTRING(FirstName,1,1) +  SUBSTRING(LastName,1,1) FROM Clerk WHERE ClerkID = @ClerkID;


END
EXEC spGetClerkInitial 1;
GO
CREATE OR ALTER PROC spGetGuestInitial
	@GuestId INT
AS
BEGIN
	SELECT SUBSTRING(FirstName,1,1) +  SUBSTRING(LastName,1,1) FROM Guest WHERE GuestId = @GuestId; 
END
GO

CREATE OR ALTER PROC spGetReservations
AS
BEGIN

	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]   FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN ROom ON Reservation.RoomId = Room.RoomId;

END

GO
CREATE OR ALTER PROC spSearchReservationsByRoomNumber
	@searchText INT
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE Room.RoomNumber = @searchText;
END
GO
EXEC spSearchReservationsByRoomNumber 101;
GO
CREATE OR ALTER PROC spSearchReservationsByRoomName
	@searchText CHAR(30)
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate,
	Room.RoomNumber,Room.RoomName,TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]   FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE Room.RoomName LIKE '%'+@searchText+'%';
END
GO
CREATE OR ALTER PROC spSearchReservationsByLastName
	@searchText CHAR(30)
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE Guest.LastName LIKE CONCAT(@searchText,'%');

END
GO
EXEC spSearchReservationsByLastName 'Stark'
GO
CREATE OR ALTER PROC spSearchReservationsByResNumber
	@searchText CHAR(12)
AS
BEGIN
	DECLARE @ReservationNumber CHAR(12);
	SET @ReservationNumber = @searchText;
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE ReservationNumber LIKE @ReservationNumber + '%';
END
EXEC spSearchReservationsByResNumber 'NP';

GO
CREATE OR ALTER PROC spSearchReservationsByCreationDate
	@searchText DATE
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE CreationDate = @searchText;
END
GO
CREATE OR ALTER PROC spSearchReservationsByCheckInDate
	@searchText DATE
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName) AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE CheckInDate = @searchText;
END
GO
CREATE OR ALTER PROC spSearchReservationsByCheckOutDate
	@searchText DATE
AS
BEGIN
	SELECT ReservationNumber, CheckInDate,CheckOutDate,CreationDate, 
	Room.RoomNumber,Room.RoomName, TRIM(Guest.LastName) + ', '+ TRIM(Guest.FirstName)  AS [GuestName]  FROM Reservation 
	INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId
	INNER JOIN Room ON Reservation.RoomId = Room.RoomId
	WHERE CheckOutDate = @searchText;
END
GO
CREATE OR ALTER PROC spSearchAvailableRooms
	@CheckInDate DATE,
	@CheckOutDate DATE
AS
BEGIn

	SELECT DISTINCT Room.RoomId,RoomName FROM Room LEFT JOIN Reservation ON Room.RoomId = Reservation.RoomId
	WHERE Room.RoomId NOT IN ( 
			SELECT Room.RoomId FROM Room LEFT JOIN Reservation ON Room.RoomId = Reservation.RoomId  
			WHERE @CheckInDate BETWEEN Reservation.CheckInDate AND Reservation.CheckOutDate
			OR @CheckOutDate BETWEEN Reservation.CheckInDate AND Reservation.CheckOutDate
			)



END
GO
CREATE OR ALTER PROC spGetAllCountries
AS
BEGIN
	SELECT * FROM Country;

END
GO
CREATE OR ALTER PROC spGetReservationDetails
	@ReservationNumber CHAR(12)
AS
BEGIN
		SELECT Guest.FirstName, Guest.MiddleName, Guest.LastName, 
			StreetAddress, City, PostalCode, Province.ProvinceAbbre,
			Country.CountryName, HomePhone, CellPhone, Email, DateOfBirth,
			CheckInDate,CheckOutDate, RoomName, RoomNumber, AdultNumber,
			ChildNumber, Reservation.BaseRate, Reservation.Total, Reservation.ReservationNumber
	
		FROM Reservation INNER JOIN Guest ON Reservation.GuestId = Guest.GuestId 
		INNER JOIN Country ON Guest.CountryId = Country.CountryId
		INNER JOIN Province ON Guest.ProvinceId = Province.ProvinceId
		INNER JOIN Room ON Room.RoomId = Reservation.RoomId
	WHERE Reservation.ReservationNumber = @ReservationNumber;

END
GO

CREATE OR ALTER PROC spGetReservationNumber
	@CheckInDate DATE,
	@CheckOutDate DATE,
	@RoomId INT
AS
BEGIN

	SELECT ReservationNumber FROM Reservation WHERE 
	CheckInDate = @CheckInDate AND CheckOutDate = @CheckOutDate AND RoomId = @RoomId;
END
GO

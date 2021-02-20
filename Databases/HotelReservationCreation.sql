CREATE DATABASE HotelReservation_N_Tier;
USE HotelReservation_N_Tier;
GO

CREATE TABLE RoomType (
	RoomTypeID INT,
	TypeDesc CHAR(30) NOT NULL,
	PRIMARY KEY (RoomTypeID)
)

--DROP TABLE RoomType;
GO
SELECT * FROM RoomType;
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (1,'Standard Suite'); 
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (2,'Superior Suite');
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (3,'Park View Suite');
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (4,'Standard Plus Suite');
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (5,'Ocean View Suite'); 
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (6,'Premiere Park View Suite');
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (7,'Presidential Suite');
INSERT INTO RoomType (RoomTypeID,TypeDesc) VALUES (8,'Royal Suite');
---

CREATE TABLE BedType (
	BedTypeID INT,
	NumberOfBeds CHAR(30) NOT NULL,
	PRIMARY KEY (BedTypeID)
)

--DROP TABLE NumberOfBeds
GO
SELECT * FROM BedType;
INSERT INTO BedType (BedTypeID, NumberOfBeds) VALUES (1,'2 Queen');
INSERT INTO BedType (BedTypeID, NumberOfBeds) VALUES (2,'1 King');
INSERT INTO BedType (BedTypeID, NumberOfBeds) VALUES (3,'1 King with sofa bed');
INSERT INTO BedType (BedTypeID, NumberOfBeds) VALUES (4,'2 Queen with sofa bed');
--
CREATE TABLE Room (
	RoomId INT,
	RoomNumber INT NOT NULL,
	RoomName CHAR(30) NOT NULL,
	BedTypeID INT NOT NULL,
	MaximumOccupancy INT NOT NULL,
	BaseRate MONEY NOT NULL,
	RoomTypeID INT NOT NULL,
	PRIMARY KEY (RoomId),
	CONSTRAINT FK_TypeForRoom FOREIGN KEY (RoomTypeID) REFERENCES RoomType (RoomTypeID),
	CONSTRAINT FK_RoomBedNum FOREIGN KEY (BedTypeID) REFERENCES BedType (BedTypeID)
)
GO
SELECT * FROM RoomType;
SELECT * FROM BedType;
SELECT * FROM Room;
--DROP TABLE Room;
INSERT INTO Room (RoomId, RoomNumber, RoomName, BedTypeID, MaximumOccupancy, BaseRate, RoomTypeID)
VALUES
	(1,101,'Copper Beach', 1, 5, 135, 1),
	(2,102,'The Cumberland',3,4,169,2),
	(3,103,'Whitetail',2,3,159,3),
	(4,104,'Pronghorn',2,3,159,3),
	(5,105,'The Elms',1,5,135,1),
	(6,201,'The Elk',4,6,219,4),
	(7,202,'Countess Crystal',1,5,189,5),
	(8,203,'The Blackstone',3,4,189,6),
	(9,204,'Alejandra',1,5,179,6),
	(10,301,'The Trumpster',2,2,399,7),
	(11,302,'The Windsor Room',4,4,429,8)
-----
GO
CREATE TABLE GuestFee (
	GuestTypeID INT PRIMARY KEY IDENTITY(1,1),
	GuestType VARCHAR(255),
	GuestRate MONEY,
	EffectiveDate DATE
)
GO
SELECT * FROM GuestFee;
--Drop TABLE GuestFee
INSERT INTO GuestFee (GuestType,GuestRate, EffectiveDate)
VALUES
	('Adult', 15, '2020-11-04'),
	('Child',10,'2020-11-04')
-----
GO
CREATE TABLE Login (
	LoginId INT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(255),
	Password VARCHAR(255)

)
SELECT * FROM Login;
--DROP TABLE Login;
INSERT INTO Login (Username,Password)
VALUES
	('nguyenpham','Ilktc0107')
-----
GO
CREATE TABLE Country (
	CountryId INT PRIMARY KEY IDENTITY(1,1),
	CountryName CHAR(30) NOT NULL
)

SELECT * FROM Country;

INSERT INTO Country 
VALUES
	('USA'),
	('Canada'),
	('Mexico'),
	('Brazil'),
	('UK'),
	('France')
--DROP TABLE Country;
-------
GO
CREATE TABLE Province (
	ProvinceId INT PRIMARY KEY IDENTITY(1,1),
	ProvinceName CHAR(30) NOT NULL,
	ProvinceAbbre CHAR(2) NOT NULL,
	CountryId INT NOT NULL,
	CONSTRAINT FK_CountryProvince FOREIGN KEY (CountryId) REFERENCES Country (CountryId)
)

SELECT * FROM Province;
INSERT INTO Province
VALUES
	('Newfoundland and Labrador','NL',2),
	('Prince Edward Island','PE',2),
	('Nova Scotia','NS',2),
	('New Brunswick','NB',2),
	('Quebec','QC',2),
	('Ontario','ON',2),
	('Manitoba','MB',2),
	('Saskatchewan','SK',2),
	('Alberta','AB',2),
	('British Columbia','BC',2),
	('Yukon','YT',2),
	('Northwest Territories','NT',2),
	('Nunavut','NU',2),
	('Alaska','AK',1),
	('Arizona','AZ',1),
	('California','CA',1),
	('Delaware','DE',1),
	('Florida','FL',1),
	('Georgia','GA',1),
	('Hawaii','HI',1),
	('Illinois','IL',1),
	('Idiana','IN',1)
SELECT * FROM Province;
--DROP TABLE Province;
-------
GO
CREATE TABLE Clerk (
	ClerkID INT PRIMARY KEY IDENTITY(1,1), 
	FirstName CHAR(30) NOT NULL,
	LastName CHAR(30) NOT NULL,
	StartDate DATE NOT NULL,
	StreetAddress CHAR(30) NOT NULL,
	City CHAR(20) NOT NULL,
	PostalCode CHAR	(7) NOT NULL,
	SIN CHAR(9) NOT NULL,
	CountryId INT NOT NULL,
	ProvinceId INT NOT NULL,
	LoginId INT NOT NULL,
	CONSTRAINT FK_ClerkCountry FOREIGN KEY (CountryId) REFERENCES Country (CountryId),
	CONSTRAINT FK_ClerkProvince FOREIGN KEY (ProvinceId) REFERENCES Province (ProvinceId),
	CONSTRAINT FK_ClerkLogin FOREIGN KEY (LoginId) REFERENCES Login (LoginId)
	
)

INSERT INTO Clerk (FirstName, LastName, StartDate, StreetAddress, City, PostalCode, SIN, CountryId, ProvinceId, LoginId)
VALUES
	('Nguyen','Pham','2020-07-28', '123 Mountain Rd.','Moncton','E1G 8I9','123446788',2,1,1)

SELECT * FROM Clerk;
--DROP TABLE Clerk;
--------
GO
CREATE TABLE Guest (
	GuestId INT IDENTITY(1,1) PRIMARY KEY,
	FirstName CHAR(30) NOT NULL,
	MiddleName CHAR(30) NULL,
	LastName CHAR(30) NOT NULL,
	StreetAddress CHAR(30) NOT NULL,
	City CHAR(20) NOT NULL,
	PostalCode CHAR(7) NOT NULL,
	HomePhone CHAR(15) NULL,
	CellPhone CHAR(15) NULL,
	Email CHAR(35) NULL,
	DateOfBirth DATETIME2 NOT NULL,
	CountryId INT NOT NULL,
	ProvinceId INT NOT NULL,
	CONSTRAINT FK_GuestCountry FOREIGN KEY (CountryId) REFERENCES Country (CountryId),
	CONSTRAINT FK_GuestProvince FOREIGN KEY (ProvinceId) REFERENCES Province (ProvinceId),
)
SELECT * FROM Guest
--DROP TABLE Guest
DELETE Guest;
---
GO
CREATE TABLE Reservation (
	ReservationNumber CHAR(12) PRIMARY KEY,
	CheckInDate DATE NOT NULL,
	CheckOutDate DATE NOT NULL,
	AdultNumber SMALLINT NOT NULL,
	ChildNumber SMALLINT NOT NULL,
	BaseRate MONEY NOT NULL,
	AdultRate MONEY NOT NULL,
	ChildRate MONEY NOT NULL,
	Total MONEY NOT NULL,
	CreationDate DATE NOT NULL,
	ClerkId INT NOT NULL,
	GuestId INT NOT NULL,
	RoomId INT NOT NULL,
	CONSTRAINT FK_ReservationClerk FOREIGN KEY (ClerkId) REFERENCES Clerk (ClerkID),
	CONSTRAINT FK_ReservationGuest FOREIGN KEY (GuestId) REFERENCES Guest (GuestId),
	CONSTRAINT FK_ReservationRoom FOREIGN KEY (RoomId) REFERENCES Room (RoomId)
)

SELECT * FROM Reservation;
--DROP TABLE Reservation;
DELETE Reservation;
----


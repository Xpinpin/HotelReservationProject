using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReservationService
    {
        ReservationRepo repo;
        public ReservationService()
        {
            repo = new ReservationRepo();
        }

        public bool AddNewReservation(Reservation reservation)
        {
            if(Validate(reservation, reservation.Guest))
                return repo.Create(reservation);
            return false;
        }

        public string GenerateLastReservationNumber()
        {
            return repo.GetReservationNumber();
        }

        public SortableBindingList<ReservationViewDTO> GetReservations()
        {
            return repo.Retrieve();
        }

        public SortableBindingList<ReservationViewDTO> GetReservationsByRoomNumber(int searchText)
        {
            return repo.SearchReservationsByRoomNumber(searchText);
        }

        public SortableBindingList<ReservationViewDTO> GetReservationsByRoomName(string searchText)
        {
            return repo.SearchReservationsByRoomName(searchText);
        }

        public SortableBindingList<ReservationViewDTO> GetReservationByLastName(string searchText)
        {
            return repo.SearchReservationsByLastName(searchText);
        }

        public SortableBindingList<ReservationViewDTO> GetReservationByReservationNumber(string searchText)
        {
            return repo.SearchReservationsByResNumber(searchText);
        }

        public SortableBindingList<ReservationViewDTO> GetReservationByCreationDate(DateTime searchText)
        {
            return repo.SearchReservationsByCreationDate(searchText);
        }
        public SortableBindingList<ReservationViewDTO> GetReservationByCheckInDate(DateTime searchText)
        {
            return repo.SearchReservationsByCheckInDate(searchText);
        }
        public SortableBindingList<ReservationViewDTO> GetReservationByCheckOutDate(DateTime searchText)
        {
            return repo.SearchReservationsByCheckOutDate(searchText);
        }

        public ReservationDetailsDTO GetReservationDetails(string reservationNumber)
        {
            return repo.RetrieveReservationDetails(reservationNumber);
        }

        private bool Validate(Reservation reservation, Guest guest)
        {
            ValidationContext reservationContext = new ValidationContext(reservation);
            ValidationContext guestContext = new ValidationContext(guest);
            List<ValidationResult> results = new List<ValidationResult>();

            Validator.TryValidateObject(reservation, reservationContext, results,true);
            Validator.TryValidateObject(guest, guestContext, results, true);

            foreach (ValidationResult result in results)
            {
                reservation.AddError(new ValidationError(result.ErrorMessage));
            }

            return reservation.Errors.Count == 0;
        }


        public string ShowReservationNumber(DateTime checkInDate, DateTime checkOutDate, int roomId)
        {
           return repo.GetReservationNumberFromDB(checkInDate, checkOutDate, roomId);
        }
    }
}

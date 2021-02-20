using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Guest : BaseEntity
    {


        [Required]
        [StringLength(30,ErrorMessage = "First name must be between 1 and 30 characters.")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Last name must be between 1 and 30 characters.")]

        public string LastName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Address must be between 1 and 30 characters.")]

        public string StreetAddress { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "City must be between 1 and 20 characters.")]

        public string City { get; set; }
     
        [Required]
        [StringLength(7, ErrorMessage = "Postal Code must be between 1 and 7 characters.")]

        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "Home Phone must be between 1 and 30 characters.")]
        public string HomePhone { get; set; }

        [StringLength(15, ErrorMessage = "Home Phone must be between 1 and 30 characters.")]
        public string CellPhone { get; set; }

        public string Email { get; set; }

        [Required]
        [AgeValidation]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        


    }
}

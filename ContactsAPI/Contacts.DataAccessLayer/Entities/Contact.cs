using System;
using System.ComponentModel.DataAnnotations;

namespace Contacts.DataAccessLayer.Entities {

    [Serializable]
    public class Contact
    {
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; set; }
        [RegularExpression("^[A-Z].*", ErrorMessage = "First letter of name must be uppercase")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must contain from 3 to 20 characters")]
        public string Name { get; set; }
        [RegularExpression("^[A-Z].*", ErrorMessage = "First letter of Surname must be uppercase")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Surname must contain from 3 to 30 characters")]
        public string Surname { get; set; }
        [StringLength(14, MinimumLength = 9, ErrorMessage = "Phone numer must contain from 9 to 14 digits")]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string Address { get; set; }
    }
}

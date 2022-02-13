using System;
using System.ComponentModel.DataAnnotations;

namespace Wedding_Site.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }
        
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string HouseHold { get; set; }

        [Display(Name = "Email (Optional)")]
        public string Email { get; set; }

        [Display(Name = "Message (Optional)")]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
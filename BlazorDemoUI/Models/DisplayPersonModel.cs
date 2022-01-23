using System.ComponentModel.DataAnnotations;

namespace BlazorDemoUI.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name is too long")]
        [MinLength(3, ErrorMessage = "First name is too short")]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Last name is too long")]
        [MinLength(3, ErrorMessage = "Last name is too short")]
        public string LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}

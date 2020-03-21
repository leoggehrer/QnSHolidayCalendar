//@QnSCodeCopy
//MdStart
using System.ComponentModel.DataAnnotations;

namespace QnSHolidayCalendar.AspMvc.Models.Modules.Account
{
    public partial class ChangePasswordViewModel : ModelObject
    {
        [ScaffoldColumn(false)]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
//MdEnd

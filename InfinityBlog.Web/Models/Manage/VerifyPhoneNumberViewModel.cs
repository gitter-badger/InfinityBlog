namespace InfinityBlog.Web.Models.Manage
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
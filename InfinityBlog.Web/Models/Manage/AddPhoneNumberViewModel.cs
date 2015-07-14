namespace InfinityBlog.Web.Models.Manage
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}
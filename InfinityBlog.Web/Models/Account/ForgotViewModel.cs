﻿namespace InfinityBlog.Web.Models.Account
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
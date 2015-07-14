namespace InfinityBlog.Web.Models.Manage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}
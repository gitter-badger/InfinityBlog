namespace InfinityBlog.Web.Models
{
    using System;
    using System.Linq;

    public class BaseViewModel
    {
        public BaseViewModel(string pageTite)
        {
            this.PageTitle = pageTite;
        }

        public string PageTitle { get; set; }
    }
}
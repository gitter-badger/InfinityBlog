using System;
using System.Linq;

namespace InfinityBlog.Web.Models
{
    public class BaseViewModel
    {
        public BaseViewModel(string pageTite)
        {
            this.PageTitle = pageTite;
        }

        public string PageTitle { get; set; }
    }
}
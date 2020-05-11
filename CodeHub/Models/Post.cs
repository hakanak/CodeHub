using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeHub.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int CategoryID { get; set; }
        public Guid PostGuid { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Code { get; set; }
        public string Owner { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
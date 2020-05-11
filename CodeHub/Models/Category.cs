using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeHub.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public Guid CategoryGuid { get; set; }
        public string CategoryName { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public int RowOrder { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class vw_Category
    {
        
        public Guid CategoryGuid { get; set; }
        public string CategoryName { get; set; }
       
        public int PostCount { get; set; }
        public int RowOrder { get; set; }

    }
}
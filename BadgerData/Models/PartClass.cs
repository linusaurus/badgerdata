
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{



    public class PartClass
    {
        public PartClass()
        {
            this.Categories = new HashSet<Category>();
        }

        public int PartClassID { get; set; }
       // public string PartClass { get; set; }

        public ICollection<Category> Categories { get; set; }
    }

}

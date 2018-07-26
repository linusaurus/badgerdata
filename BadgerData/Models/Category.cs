
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Category
    {
        public Category()
        {
            this.PartTypes = new HashSet<PartType>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? PartClassID { get; set; }

        public PartClass PartClass { get; set; }
        public ICollection<PartType> PartTypes { get; set; }
    }

}

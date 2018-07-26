
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class PartType
    {
        public PartType()
        {
            this.Parts = new HashSet<Part>();
        }

        public int PartTypeID { get; set; }
        //public string PartType { get; set; }
        public int? Categoryid { get; set; }

        public Category Category { get; set; }
        public ICollection<Part> Parts { get; set; }
    }

}

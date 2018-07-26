
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            this.Parts = new HashSet<Part>();
        }

        public int UnitOfMeasureID { get; set; }
        public string UnitOfMeasureName { get; set; }

        public ICollection<Part> Parts { get; set; }
    }

}

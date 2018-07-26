
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime? ProductionDate { get; set; }
        public int? ProjectID { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public string ArchRef { get; set; }
        public string Note { get; set; }
        public bool Omit { get; set; }
        // ---------------------------------
        //Parent Container
        public Project Project { get; set; }
        //----------------------------------
        //relationships
        public ICollection<Subassembly> Subassemblies { get; set; } = new List<Subassembly>();
    }
}

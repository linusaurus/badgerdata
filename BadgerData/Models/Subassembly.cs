
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Subassembly
    {
        public int SubassemblyID { get; set; }
        // Parent
        public int ProductID{ get; set; }
        public string SubassemblyName { get; set; }
        public string MakeFile { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
        public decimal D { get; set; }
      
    }


}
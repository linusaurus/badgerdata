
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Manu
    {
        public int ManuID { get; set; }
        public string Manufacturer { get; set; }
        public string Phone { get; set; }
        public string WebAddress { get; set; }
        public int? ManuCategoryID { get; set; }
    }

}

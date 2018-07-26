
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class RequisitionItem
    {
        public int RequisitionItemID { get; set; }
        public int? RequisitionlD { get; set; }
        public int? PartID { get; set; }
        public int? LineItemSourceID { get; set; }
        public decimal? Qnty { get; set; }
        public string Description { get; set; }

        public Requisition Requisition { get; set; }
    }

}

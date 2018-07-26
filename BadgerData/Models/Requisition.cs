
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Requisition
    {
        public Requisition()
        {
            
            this.RequisitionItem = new HashSet<RequisitionItem>();
        }

        public int RequisitionID { get; set; }
        public int? JobID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public decimal? RequisitionTotal { get; set; }
        public bool? Submitted { get; set; }
        public DateTime? RequisitionSubmittedDate { get; set; }
        // Navigation Items
        public ICollection<RequisitionItem> RequisitionItem { get; set; }
    }

}

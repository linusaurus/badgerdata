
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Claim
    {
        public int ClaimID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public string SupplierOrder { get; set; }
        public DateTime? ClaimDate { get; set; }
        public int? EmployeeID { get; set; }

        public ICollection<ClaimItem> ClaimItems { get; set; }
    }
}


using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class OrderReceipt
    {
        public OrderReceipt()
        {
            this.Inventory = new HashSet<Inventory>();
        }

        public int OrderReceiptID { get; set; }
        public int? EmployeeID { get; set; }
        public int? JobID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public ICollection<Inventory> Inventory{ get; set; }
    }

}


using System;
using System.Collections.Generic;

namespace BadgerData.Models
{



    public class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.Attachments = new HashSet<Attachment>();
            this.PurchaseLineItems = new HashSet<PurchaseLineItem>();
        }

        public int PurchaseOrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Expected_Date { get; set; }
        public int? SupplierID { get; set; }
        public int? EmployeeID { get; set; }
        public string SalesRep { get; set; }
        public int? Job_id { get; set; }
        public bool? Taxable { get; set; }
        public int? ShipID { get; set; }
        public decimal? OrderTotal { get; set; }
        public bool? Received { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal? SubTotal { get; set; }
        public string Memo { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string OrderFormat { get; set; }

        public Supplier Supplier { get; set; }
        public Employee Employee { get; set; }
        public Job Job { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
        public ICollection<PurchaseLineItem> PurchaseLineItems { get; set; } = new List<PurchaseLineItem>();
    }

}

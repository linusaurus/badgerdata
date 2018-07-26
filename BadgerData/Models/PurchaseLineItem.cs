
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BadgerData.Models
{


    public class PurchaseLineItem
    {
        public int LineID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int? JobID { get; set; }
        public int? PartID { get; set; }
        public decimal? UnitCost { get; set; }
        public string Description { get; set; }
        public decimal? Qnty { get; set; }
        public decimal? Extended { get; set; }
        public bool? Received { get; set; }
        public int? UnitOfMeasureID { get; set; }
        public int? RequisitionID { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Thick { get; set; }
        public decimal? Weight { get; set; }
        public string SupplierPartName { get; set; }
        public string BCode { get; set; }
        public string Note { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }

}

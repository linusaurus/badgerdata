
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Part
    {
        public Part()
        {
            this.Documents = new HashSet<DocumentParts>();
        
        }

        public int PartID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string PartNum { get; set; }
        public int? ManuID { get; set; }
        public bool? Obsolute{ get; set; }
        public int? PartTypeID { get; set; }
        public decimal? Cost { get; set; }
        public int? UnitOfMeasureID { get; set; }
        public string Location { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Waste { get; set; }
        public decimal? MarkUp { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierDescription { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? UseSupplierNameFlag { get; set; }
        public string ManuPartNum { get; set; }
        public string SKU { get; set; }

        public PartType PartType { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<DocumentParts> Documents { get; set; }

    }

}

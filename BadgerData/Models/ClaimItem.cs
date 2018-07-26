
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class ClaimItem
    {
        public int ClaimItemID { get; set; }
        public int? ClaimID { get; set; }
        public int? LineID { get; set; }
        public int? PartID { get; set; }
        public string Bcode { get; set; }
        public string Description { get; set; }
        public int? TransActionTypeID { get; set; }
        public int? ProductID { get; set; }
        public string DefectDescription { get; set; }

        public ICollection<ClaimDocument> ClaimDocuments { get; set; } = new List<ClaimDocument>();
    }
}

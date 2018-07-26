
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class ClaimDocument
    {
        public int? ClaimDocumentID { get; set; }
        //  Parent Foreign Key-can not be nullable for 
        //  cascade delete to work
        public int ClaimItemID { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentExtension { get; set; }
    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BadgerData.Models
{

    public class Document
    {
        public Document()
        {
            this.Parts = new HashSet<DocumentParts>();
        }
     
        public int DocumentID { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentView { get; set; }
        public int? PartID { get; set; }

        public ICollection<DocumentParts> Parts { get; set; }
    }

}
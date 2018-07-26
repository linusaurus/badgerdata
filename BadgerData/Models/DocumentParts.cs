

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BadgerData.Models
{

    public class DocumentParts
    {
       
        public int PartID { get; set; }
        public int DocumentID { get; set; }
    }

}
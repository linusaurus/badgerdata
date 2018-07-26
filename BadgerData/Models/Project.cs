
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Project
    {
        public Project()
        {
            this.Product = new HashSet<Product>();
        }

        public int ProjectID { get; set; }
        public int? JobID { get; set; }
        public string ProjectName { get; set; }
        public DateTime? Created { get; set; }
        public bool? Active { get; set; }
        public bool? IsContracted { get; set; }
        

        public ICollection<Product> Product { get; set; }
    }

}


using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Job
    {
        public Job()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int job_id { get; set; }
 
        public string jobname { get; set; }
        public int? jobnumber { get; set; }
        public string jobdesc { get; set; }
       
        public bool? Retired { get; set; }
        public bool? Visible { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }

}

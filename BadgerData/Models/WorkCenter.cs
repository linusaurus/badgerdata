
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class WorkCenter
    {
        public int WorkCenterID { get; set; }
        public string WorkCenterName { get; set; }

        public decimal? CostRate { get; set; }
        public decimal? Availability { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
     

    

}

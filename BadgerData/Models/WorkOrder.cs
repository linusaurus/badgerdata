
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public int? ProjectID { get; set; }
        public int? ProductID { get; set; }
        public DateTime WorkOrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
     

    

}

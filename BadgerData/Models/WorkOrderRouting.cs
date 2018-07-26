
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class WorkOrderRouting
    {
        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public int OperationSequence { get; set; }
        public int? EmployeeID { get; set; }
        public int? TaskID { get; set; }
        public int? LocationID { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }

        public decimal? PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }


        public DateTime? ModifiedDate { get; set; }
    }
     

    

}

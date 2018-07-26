
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int? TaskType { get; set; }
        public decimal? Rate { get; set; }
        public decimal? MarkUp { get; set; }
        public int? WorkCenter { get; set; }

 
    }

}

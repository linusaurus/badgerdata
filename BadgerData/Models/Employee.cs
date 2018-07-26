
using System;
using System.Collections.Generic;

namespace BadgerData.Models
{


    public class Employee
    {
        public Employee()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public bool? IsPurchaser { get; set; }
        public string EmployeeEmail { get; set; }
        public bool? Show { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }

}
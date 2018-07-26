using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BadgerData;


namespace BadgerDataTest
{
    [TestClass]
    public class BasicDataAccess
    {
        [TestMethod]
        public void TestGetDocument()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var docs = ctx.Document.ToList();
            Assert.IsTrue(docs.Count > 0);
        }

        [TestMethod]
        public void TestGetParts()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.Part.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestDocParts()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext()) { 
            var parts = ctx.DocumentParts.ToList();
            Assert.IsTrue(parts.Count > 0);
            }
        }

        [TestMethod]
        public void TestGetJobs()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.Job.ToList();
            Assert.IsTrue(parts.Count > 0);
        }
        [TestMethod]
        public void TestGetPurchaseOrders()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.PurchaseOrder();
                x.EmployeeID = 8;
                x.Expected_Date = DateTime.Today.AddDays(3);
                x.ShipID = 1;
                x.Received = false;
                x.OrderTotal = 1.0m;
                x.OrderFormat = "Simple";
                x.SalesRep = "Little Dicky";
                x.SupplierID = 77;
                x.Taxable = true;
                x.Tax = 2.0m;
                x.Job_id = 4;
                x.Memo = "Long winded talk talk talk --";
                x.Shipping = 1.0m;
                x.OrderDate = DateTime.Today;
                ctx.Add(x);
                ctx.SaveChanges();
                var parts = ctx.PurchaseOrder.ToList();
                Assert.IsTrue(parts.Count > 0);
            }
        }

        [TestMethod]
        public void TestGetPurchaseLineItems()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.PurchaseLineItem();
                x.BCode = "1234-223-12-1123";
                x.Description = "Item for purhcase that has a very long descritpion";
                x.JobID = 3;
                x.Length = 120.0m;
                x.Width = 65.234m;
                x.Thick = 1.0m;
                x.SupplierPartName = "Big Funky Thing 113-2";
                x.UnitCost = 12.5m;
                x.UnitOfMeasureID = 1;
                x.Weight = 2.0m;
                x.Received = false;
                x.Qnty = 1.0m;
                x.PurchaseOrderID = 19676;
                x.Thick = 6.0m;
                x.PartID = 100;
                x.Extended = x.Qnty * x.UnitCost;
                x.Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. . Aenean quam.";
                ctx.Add(x);
                ctx.SaveChanges();
                var result = ctx.PurchaseLineItem.ToList();

                Assert.IsTrue(result.Count > 0);
            }
        }

        [TestMethod]
        public void TestGetEmployee()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.Employee.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestGetInventory()
        {


            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                try
                {
                    var inv = ctx.Inventory.ToList();
                    Assert.IsTrue(inv.Count > 0);

                }
                catch (DataMisalignedException ex)
                {
                    object g = ex;
                    throw;
                }

            }

        }

        [TestMethod]
        public void TestGetManu()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.Manu.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestGetSupplier()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.Supplier.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestGetPartClass()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.PartClass.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestGetPartType()
        {
            var ctx = new BadgerData.DataAccess.BadgerDataContext();
            var parts = ctx.PartType.ToList();
            Assert.IsTrue(parts.Count > 0);
        }

        [TestMethod]
        public void TestGetAccountType()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
               var   at = new BadgerData.Models.AccountType();
                ctx.AccountType.Add(at);
                at.AccountTypeName = "COD";
                ctx.SaveChanges();
                var atr = ctx.AccountType.Where(c => c.AccountTypeName == "COD");
                ctx.RemoveRange(atr);
                ctx.SaveChanges();
            }
        }

        [TestMethod]
        public void TestGetProduct()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())

            {
                
               
                BadgerData.Models.Product x = new BadgerData.Models.Product();
                x.ArchRef = "big funky things";
                x.ProductName = "Unit 2";
                x.Depth = 6.25m;
                x.Height = 8.25m;
                x.Note = "Very long winded note";
                x.ProductionDate = DateTime.Today.AddDays(-2);
                x.ProjectID = 11;
                x.Width = 120.75m;
                x.Omit = true;
                ctx.Add(x);
                ctx.SaveChanges();
                var items = ctx.Product.Include(r=> r.Subassemblies).ToList();
                Assert.IsTrue(items.Count > 0);
            }
            
        }

        [TestMethod]
        public void TestGetProductsAndSubassemblies()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())

            {

                BadgerData.Models.Product x = new BadgerData.Models.Product();
                var items = ctx.Product.Include(r => r.Subassemblies).ToList();
                Assert.IsTrue(items.Count > 0);
            }

        }

        [TestMethod]
        public void TestGetSubAssembly()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {


                BadgerData.Models.Subassembly x = new BadgerData.Models.Subassembly();
                x.ProductID = 1;
                x.SubassemblyName = "Unit 3";
                x.MakeFile = "FrameWorks.Makes.System5010.PXPAwningRightHandLL5";
                x.H = 98.25m;
                x.W = 123.5m;
                x.D = 3.75m;
                ctx.Add(x);
                ctx.SaveChanges();
                var items = ctx.Product.ToList();
                Assert.IsTrue(items.Count > 0);
            }

        }

        [TestMethod]
        public void TestClaim()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                BadgerData.Models.Claim x = new BadgerData.Models.Claim();
                x.ClaimDate = DateTime.Today;
                x.EmployeeID = 8;
                x.PurchaseOrderID = 5001;
                x.SupplierOrder = "12234R3";
                ctx.Add(x);
                ctx.SaveChanges();
                var t = ctx.Claim.Where(c => c.PurchaseOrderID == 5001).First();

                var parts = ctx.Claim.ToList();
                Assert.IsTrue(parts.Count > 0);
                Assert.AreEqual(t.EmployeeID, 8);
                Assert.AreEqual(t.SupplierOrder, "12234R3");
                Assert.IsTrue(t.ClaimID > 0);
                ctx.Remove(t);
                ctx.SaveChanges();
                parts = ctx.Claim.ToList();
                Assert.IsTrue(parts.Count == 0);
            }

        }
        [TestMethod]
        public void TestClaimItems()
        {
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                BadgerData.Models.Claim x = new BadgerData.Models.Claim();
                x.ClaimDate = DateTime.Today;
                x.EmployeeID = 8;
                x.PurchaseOrderID = 5001;
                x.SupplierOrder = "12234R3";
                ctx.Add(x);
                ctx.SaveChanges();
                for (int i = 0; i < 3; i++)
                {
                    var item = new BadgerData.Models.ClaimItem();
                    item.ClaimID = x.ClaimID;
                    item.Bcode = "1-34-12-111" + i.ToString();
                    item.LineID = 1234 + i;
                    item.Description = "Description" + i.ToString();
                    item.DefectDescription = "Brocken";
                    item.PartID = 1234;
                   
                    ctx.Add(item);
                    ctx.SaveChanges();   
                }

                ctx.SaveChanges();
                var testItems = ctx.ClaimItem.ToList();
                Assert.IsTrue(testItems.Count > 0);
                var rm = ctx.ClaimItem.ToList();
                ctx.RemoveRange(rm);
                ctx.SaveChanges();
                var tm = ctx.Claim.ToList();
                ctx.RemoveRange(tm);
                ctx.SaveChanges();
            }
        }

        [TestMethod]
        public void TestPurchaseOrder()
        {
            
            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {

                ctx.Database.EnsureCreated();
                BadgerData.Models.PurchaseOrder x = new BadgerData.Models.PurchaseOrder();
                x.OrderDate = DateTime.Today;
                x.EmployeeID = 8;
                x.Expected_Date = DateTime.Today.AddDays(2);         
                x.Job_id = 1023;
                x.Memo = "Testing 1,2,3";
                x.Received = false;
                x.SupplierID = 1437;
                x.SubTotal = 0.0m;
                x.OrderTotal = 0.0m;
                x.Shipping = 1.0m;
                x.Tax = 0.0m;
                x.SalesRep = "Dick";
                x.ShipID = 1;
                x.Shipping = 0.0m;
                x.Taxable = false;
                ctx.Add(x);
                ctx.SaveChanges();
                int ordernum = x.PurchaseOrderID;
                var t = ctx.PurchaseOrder.Where(c => c.PurchaseOrderID == ordernum).First();

                var o = ctx.PurchaseOrder.Where(r => r.PurchaseOrderID == t.PurchaseOrderID).First();
                Assert.IsTrue(t.PurchaseOrderID > 0);
            }
        }


        [TestMethod]
        public void TestWorkOrder()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.WorkOrder();
                x.ProjectID = 1120;
                x.ProductID = 12;
                x.WorkOrderDate = DateTime.Today;
                x.StartDate = DateTime.Today.AddDays(7);
                x.EndDate = DateTime.Today.AddDays(30);
                ctx.Add(x);
                ctx.SaveChanges();
                var result = ctx.WorkOrder.ToList();

                Assert.IsTrue(result.Count > 0);
            }
        }

        [TestMethod]
        public void TestWorkOrderRouting()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.WorkOrderRouting();
                x.WorkOrderID = 2;
                x.ProductID = 11;
                x.ScheduledStartDate = DateTime.Today;
                x.ScheduledEndDate = DateTime.Today.AddDays(7);
                x.ActualStartDate = DateTime.Today;
                x.ActualEndDate = DateTime.Today.AddMonths(1);
                x.PlannedCost = 3.25m;
                x.TaskID = 1;
               
                x.OperationSequence =4;
                ctx.Add(x);
                ctx.SaveChanges();
                var result = ctx.WorkOrder.ToList();

                Assert.IsTrue(result.Count > 0);
            }
        }

        [TestMethod]
        public void TestTask()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.Task();
                x.MarkUp = 1.0m;
                x.Rate = 85.00m;
                x.TaskDescription = "Drafting, Design,Engineering";
                x.TaskName = "Design";
                x.TaskType = 1;
                x.WorkCenter = 1;
                
             
                ctx.Add(x);
                ctx.SaveChanges();
                var result = ctx.Task.ToList();

                Assert.IsTrue(result.Count > 0);
            }
        }

        [TestMethod]
        public void TestProduct()
        {

            using (var ctx = new BadgerData.DataAccess.BadgerDataContext())
            {
                var x = new BadgerData.Models.Product();
                x.Height = 1.0m;
                x.Depth = 6.0m;
                x.Width = 120.25m;
                x.Omit = false;
                x.ProjectID = 13;
                x.ProductionDate = DateTime.Today;
                x.ProductName = "big pile of shit";
                x.ArchRef = "Mister SHitheads Bathroom";

                ctx.Add(x);
                ctx.SaveChanges();
                var result = ctx.Task.ToList();

                Assert.IsTrue(result.Count > 0);
            }
        }

    }
}

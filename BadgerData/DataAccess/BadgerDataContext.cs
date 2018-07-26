using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using BadgerData.Models;
using BadgerData.DataAccess.Configurations;


namespace BadgerData.DataAccess
{
    public class BadgerDataContext : DbContext
    {
       
        private const string ConnectionString = @"Server=192.168.10.3;database=mosiac;uid=root;pwd=Kx09a32x;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //----------------optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseMySql(ConnectionString);
        }

        public DbSet<AccountType> AccountType { get; set; }//Revised
        public DbSet<Attachment> Attachments { get; set; }//Revised
        public DbSet<Claim> Claim { get; set; } //Revised
        public DbSet<ClaimItem> ClaimItem { get; set; } //Revised
        public DbSet<ClaimDocument> ClaimDocument { get; set; } //Revised      
        public DbSet<Product> Article { get; set; } // Revised
        public DbSet<Category> Categories { get; set; }   //Revised
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }  // Revised-Added
        public DbSet<Document> Document { get; set; }  //Revised
        public DbSet<DocumentParts> DocumentParts { get; set; } //No-Change
        public DbSet<Finish> Finish { get; set; }
        public DbSet<Globals> Globals { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Job> Job { get; set; }  //Revised
        public DbSet<Manu> Manu { get; set; }  //Revised
        public DbSet<OrderReceipt> OrderReceipt { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<PartClass> PartClass { get; set; }
        public DbSet<PartType> PartType { get; set; }
        public DbSet<ShipBy> ShipBy { get; set; }
        public DbSet<Requisition> Requisition { get; set; }
        public DbSet<RequisitionItem> RequisitionItem { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
        public DbSet<WorkCenter> WorkCenter { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseLineItem> PurchaseLineItem { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Subassembly> Subassembly { get; set; }
        public DbSet<Supplier> Supplier { get; set; }


        protected override void
            OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentPartConfig());
            modelBuilder.ApplyConfiguration(new JobConfig());
            modelBuilder.ApplyConfiguration(new SubAssemblyConfig());
            modelBuilder.ApplyConfiguration(new PurchaseLineItemConfig());
            modelBuilder.ApplyConfiguration(new PurchaseOrderConfig());
            modelBuilder.ApplyConfiguration(new ClaimDocumentConfig());
            modelBuilder.ApplyConfiguration(new ClaimConfig());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureConfig());
            modelBuilder.ApplyConfiguration(new InventoryConfig());
            modelBuilder.ApplyConfiguration(new JobConfig());
            modelBuilder.ApplyConfiguration(new PartConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ManuConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new RequisitionConfig());
            modelBuilder.ApplyConfiguration(new ShipByConfig());
            modelBuilder.ApplyConfiguration(new SupplierConfig());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());
            modelBuilder.ApplyConfiguration(new UnitOfMeasureConfig());
            modelBuilder.ApplyConfiguration(new WorkOrderConfig());
            modelBuilder.ApplyConfiguration(new WorkOrderRoutingConfig());
            modelBuilder.ApplyConfiguration(new WorkCenterConfig());
            modelBuilder.ApplyConfiguration(new GlobalsConfig());
            modelBuilder.ApplyConfiguration(new TaskConfig());
            modelBuilder.ApplyConfiguration(new TransActionTypeConfig());
            modelBuilder.ApplyConfiguration(new ManuConfig());
            modelBuilder.ApplyConfiguration(new OrderReceiptConfig());
            modelBuilder.ApplyConfiguration(new TransActionTypeConfig());
            modelBuilder.ApplyConfiguration(new RequisitionItemConfig());
            modelBuilder.ApplyConfiguration(new DocumentConfig());
        }

    }
}

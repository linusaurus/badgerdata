using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class PurchaseOrderConfig : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> entity)
        {
            entity.HasKey(p => p.PurchaseOrderID);

            //------------------------------------------------
            // Relationships

            //entity.HasMany(c => c.PurchaseLineItems).WithOne()
            //    .HasForeignKey(k => k.PurchaseOrderID).IsRequired();
               
        }
    }
}

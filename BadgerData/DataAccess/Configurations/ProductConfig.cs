using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(p => p.ProductID);

            entity.HasMany(c => c.Subassemblies).WithOne()
              .HasForeignKey(k => k.ProductID).IsRequired();
        }
    }
}
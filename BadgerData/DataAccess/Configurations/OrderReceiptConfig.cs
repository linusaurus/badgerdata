using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class OrderReceiptConfig : IEntityTypeConfiguration<OrderReceipt>
    {
        public void Configure(EntityTypeBuilder<OrderReceipt> entity)
        {
            entity.HasKey(p => p.OrderReceiptID);
        }
    }
}

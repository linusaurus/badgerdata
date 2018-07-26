using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class PurchaseLineItemConfig : IEntityTypeConfiguration<PurchaseLineItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseLineItem> entity)
        {
            entity.HasKey(p => p.LineID);

            //-----------------------------------
            // Relationships

           
        }
    }
}

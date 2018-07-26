using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class RequisitionItemConfig : IEntityTypeConfiguration<RequisitionItem>
    {
        public void Configure(EntityTypeBuilder<RequisitionItem> entity)
        {
            entity.HasKey(p => p.RequisitionItemID);
        }
    }
}
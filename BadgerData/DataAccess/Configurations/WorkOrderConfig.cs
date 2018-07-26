using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class WorkOrderConfig : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> entity)
        {
            entity.HasKey(p => p.WorkOrderID);
        }
    }
}


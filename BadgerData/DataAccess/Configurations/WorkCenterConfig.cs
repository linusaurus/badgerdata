﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class WorkCenterConfig : IEntityTypeConfiguration<WorkCenter>
    {
        public void Configure(EntityTypeBuilder<WorkCenter> entity)
        {
            entity.HasKey(p => p.WorkCenterID);
        }
    }
}


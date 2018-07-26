﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class TransActionTypeConfig : IEntityTypeConfiguration<TransActionType>
    {
        public void Configure(EntityTypeBuilder<TransActionType> entity)
        {
            entity.HasKey(p => p.TransactionsTypeID);
        }
    }
}
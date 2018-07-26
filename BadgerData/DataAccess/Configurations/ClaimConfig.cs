using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class ClaimConfig : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> entity)
        {
            entity.HasKey(p => p.ClaimID);

            //---------------------------------------------
            //Relationships

            entity.HasMany(c => c.ClaimItems);
            entity.HasMany(p => p.ClaimItems).WithOne().HasForeignKey(d => d.ClaimID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
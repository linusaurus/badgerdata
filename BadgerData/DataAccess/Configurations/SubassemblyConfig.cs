using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class SubAssemblyConfig : IEntityTypeConfiguration<Subassembly>
    {
        public void Configure(EntityTypeBuilder<Subassembly> entity)
        {
            entity.HasKey(p => p.SubassemblyID);

           
        }
    }
}
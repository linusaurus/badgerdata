using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BadgerData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadgerData.DataAccess.Configurations
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public  void  Configure( EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(p => new { p.DocumentID, p.PartID });

            //---------------------------------------------
            // Relationships

           
        }
    }
}

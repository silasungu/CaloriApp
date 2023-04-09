using CaloriApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Mapping
{
    public class WaterMapping : IEntityTypeConfiguration<Water>
    {

        public void Configure(EntityTypeBuilder<Water> builder)
        {
            builder.HasKey(x => x.WaterID);
            builder.Property(x => x.WaterID)
              .ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.WaterAmount)
                
                ;
            builder.Property(x => x.GlassOfWater)
               
                .IsRequired();
            builder.Property(x => x.DateTime)
                .IsRequired();



            //builder.HasOne(x => x.User)
            //  .WithMany(x => x.Water)
            //  .HasForeignKey(x => x.UserID);
        }
    }
}

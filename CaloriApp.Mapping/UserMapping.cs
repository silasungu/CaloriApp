using CaloriApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CaloriApp.Mapping
{
    public class UserMapping: IEntityTypeConfiguration<User>
    {
       

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserID);

            builder.Property(x => x.UserID).ValueGeneratedOnAdd().IsRequired();


            builder.Property(x => x.UserName)
                
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(x => x.Height);

            builder.Property(x => x.Weight);

            builder.Property(x => x.WaterAmount);




            builder.Property(x => x.Email)
               
               .IsRequired();

            builder.Property(x => x.Password)
                .HasMaxLength(18).IsUnicode(false)
                .IsRequired();



            builder.Property(x => x.DailyCalorie);

            builder.Property(x => x.RequiredCalorie);


            builder.HasMany(x => x.UserMeals).WithOne
           (x => x.User)
            .HasForeignKey(x => x.UserID);

            builder.HasMany(x => x.Water).WithOne
           (x => x.User)
           .HasForeignKey(x => x.UserID);






        }
    }
}

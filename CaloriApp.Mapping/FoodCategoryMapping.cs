using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaloriApp.Entities.Concrete;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CaloriApp.Mapping
{
    public class FoodCategoryMapping : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.HasKey(fc => fc.FoodCategoryID);
            //builder.Property(fc => fc.FoodCategoryID).ValueGeneratedOnAdd()
            //    .IsRequired();
            builder.Property(fc => fc.CategoryName).HasMaxLength(50).IsRequired();


            //Bir kategorinin bir çok yemeği olur bire çokun çok kısmı!
            builder.HasMany(f => f.Foods).WithOne
               (fc => fc.FoodCategory)
                .HasForeignKey(f => f.FoodCategoryID); //bir yimeğen tek kategorisi olur 
        }
    }

}

using CaloriApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Mapping
{
    public class FoodMapping: IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.FoodID);

            builder.Property(f => f.FoodID).ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(f => f.FoodName)
                
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Calorie)
               
                .IsRequired();

            builder.Property(f => f.Carbonhidrate)
                
                .IsRequired();

            builder.Property(f => f.Protein)
                
                .IsRequired();

            builder.Property(f => f.Fat)
                
                .IsRequired();

            builder.Property(f => f.Description)
             
             ;

            //bir yemeğin bir kategorisi olur bireçokun biri 

            builder.HasOne(f => f.FoodCategory)
                .WithMany(fc => fc.Foods)          //bir kategorinin bir çok yemeği olabilir
                .HasForeignKey(f => f.FoodCategoryID);

            //builder.HasMany(x => x.UserMealsAndFoods).WithOne(x => x.Food).HasForeignKey(x => x.FoodID);
        }
    }
}

using CaloriApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Mapping
{
    public class UserMealsAndFoodsMapping : IEntityTypeConfiguration<UserMealsAndFoods>

    {
      

        public void Configure(EntityTypeBuilder<UserMealsAndFoods> builder)
        {
            builder.HasKey(x => new { x.FoodID, x.UserMealID });

            builder.Property(f => f.Calorie)
                
                .IsRequired();

            builder.Property(f => f.Carbonhidrate)
               
                .IsRequired();


            builder.Property(f => f.Protein)
                
                .IsRequired();

            builder.Property(f => f.Fat)
               
                .IsRequired();

        }
    }
}

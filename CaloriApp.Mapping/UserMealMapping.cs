using CaloriApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Mapping
{
    public class UserMealMApping : IEntityTypeConfiguration<UserMeal>
    {
        

        public void Configure(EntityTypeBuilder<UserMeal> builder)
        {
            builder.HasKey(x => x.UserMealID);
            builder.Property(c => c.UserMealID)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.MealDate)
                .IsRequired();

            builder.Property(x => x.MealTimes)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserMeals)
                .HasForeignKey(x => x.UserID);

            builder.HasMany(x => x.UserMealsAndFoods).WithOne(x => x.UserMeal).HasForeignKey(x => x.UserMealID);
        }
    }
}


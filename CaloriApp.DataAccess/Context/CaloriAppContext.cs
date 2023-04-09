using CaloriApp.Entities.Concrete;
using CaloriApp.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.DataAccess.Context
{
    public class CaloriAppContext: DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMeal> UserMeals { get; set; }
        public DbSet<Water> Water { get; set; }

        public DbSet<UserMealsAndFoods> UserMealsAndFoods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;database=CaloriAppDb;uid=sa;pwd=123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FoodCategoryMapping());
            modelBuilder.ApplyConfiguration(new UserMealsAndFoodsMapping());
            modelBuilder.ApplyConfiguration(new FoodMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new WaterMapping());
            modelBuilder.ApplyConfiguration(new UserMealMApping());



            base.OnModelCreating(modelBuilder);
        }
        public static void ResetItem()
        {

            using (var db = new CaloriAppContext())
            {
                foreach (var item in db.Users)
                {
                    item.WaterAmount = 0;
                    item.DailyCalorie = 0;
                    item.DailyCarbonhidrate = 0;
                    item.DailyFat = 0;
                    item.DailyProtein = 0;

                }


                db.SaveChanges();
            }

        }
    }
}
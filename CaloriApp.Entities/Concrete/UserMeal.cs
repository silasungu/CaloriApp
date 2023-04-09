using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class UserMeal
    {
        public int UserMealID { get; set; }
        public DateTime MealDate { get; set; } = DateTime.Now;
        public MealTimes MealTimes { get; set; }
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public double Portion { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }

        public int FoodID { get; set; }


        //public List<Food> Foods { get; set; }

        public List<UserMealsAndFoods> UserMealsAndFoods { get; set; }
    }
}

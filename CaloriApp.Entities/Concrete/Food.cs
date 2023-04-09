using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public string Description { get; set; }


        public int FoodCategoryID { get; set; }  //1-C N-F

        public FoodCategory FoodCategory { get; set; }

        //public List<UserMeal> UserMeals { get; set; }
        public List<UserMealsAndFoods> UserMealsAndFoods { get; set; }
    }
}

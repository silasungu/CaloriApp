using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class UserMealsAndFoods
    {
        public readonly object Calorie;
        public readonly object Carbonhidrate;
        public readonly object Protein;
        public readonly object Fat;

        public int FoodID { get; set; }
        public int UserMealID { get; set; }

        //Navigate Prop
        public virtual Food Food { get; set; }
        public virtual UserMeal UserMeal { get; set; }
    }
}

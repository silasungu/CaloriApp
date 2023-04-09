using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public double DailyCalorie { get; set; }
        public double RequiredCalorie { get; set; }
        public double DailyFat { get; set; }
        public double DailyCarbonhidrate { get; set; }
        public double DailyProtein { get; set; }
        public double WaterAmount { get; set; }

        public virtual List<UserMeal> UserMeals { get; set; }
        public List<Water> Water { get; set; }
    }
}

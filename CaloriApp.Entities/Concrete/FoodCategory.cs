using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class FoodCategory
    {
        public int FoodCategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Food> Foods { get; set; }
    }
}

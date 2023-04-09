﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Entities.Concrete
{
    public class Water
    {
        public Water()
        {
            WaterAmount = 0;
        }

        public int WaterID { get; set; }

        private double _waterAmount;

        public double? WaterAmount
        {
            get { return _waterAmount; }
            set
            {
                if (value < 0)
                    _waterAmount = 0;
                else
                    _waterAmount = Convert.ToDouble(value);
            }

        }

        public int GlassOfWater { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;


        public int UserID { get; set; }

        public User User { get; set; }
    }
}

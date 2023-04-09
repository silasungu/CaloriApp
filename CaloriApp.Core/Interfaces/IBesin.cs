using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriApp.Core.Interfaces
{
    public interface IBesin
    {
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
    }
}

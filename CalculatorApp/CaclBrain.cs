using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CaclBrain
    {
        public double firstoperand;
        public double secondoperand;
        public double result;

        public double Plus()
        {
            result = firstoperand + secondoperand;
            return result;
        }

    }
}

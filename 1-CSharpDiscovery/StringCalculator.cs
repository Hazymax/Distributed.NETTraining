using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class StringCalculator : Calculator
    {
        public StringCalculator()
        {
        }

        public double onePlusTwo(String str)
        {
            string[] nb = str.Split('+');
            double sum = 0;
            foreach (String element in nb)
            {
                if (element == "pi") { sum = sum + 3.14; }
                else { sum = sum + double.Parse(element); }
            }
            return sum;
        }

    }
}

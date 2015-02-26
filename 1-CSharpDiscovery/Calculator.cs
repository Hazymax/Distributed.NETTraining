using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class Calculator
    {
        public string Name { get; set; }

        public Calculator()
        {
            this.Name = "Calculator";
        }

        public double sumOfTheArray(double[] tab)
        {
            double sum = 0;
            foreach (double f in tab)
            {
                sum = sum + f;
            }
            return sum;
        }

        public double onePlusTwo(String str)
        {
            string[] nb = str.Split('+');
            double sum = 0;
            foreach (String element in nb)
            {
                if (element == "pi"){sum = sum + 3.14;}
                else {sum = sum + double.Parse(element);}
            }
            return sum;
        }

    }

    
}

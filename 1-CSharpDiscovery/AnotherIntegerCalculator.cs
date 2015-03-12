using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class AnotherIntegerCalculator : Calculator
    {
        public AnotherIntegerCalculator() { }

        public override double sumOfTheArray(double[] tab)
        {
            double retour= 0;
            foreach (double d in tab)
            {
                retour += (int)d;
            }

            return retour;
        }

    }
}

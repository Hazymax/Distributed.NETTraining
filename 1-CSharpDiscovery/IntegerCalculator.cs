using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class IntegerCalculator : Calculator
    {
        public IntegerCalculator() {}

        public new double sumOfTheArray(double[] tab)
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

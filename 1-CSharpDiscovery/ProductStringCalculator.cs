using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class ProductStringCalculator : AbstractStringCalculator
    {
        public ProductStringCalculator() { }

        public override double Calculate(String str)
        {
            String[] tab = str.Split('*');
            double retour=0;
            foreach(String s in tab){
                retour *= double.Parse(s);
            }
            return retour;
        }
    }
}

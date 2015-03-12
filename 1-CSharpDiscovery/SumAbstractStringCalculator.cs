using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDiscovery
{
    class SumAbstractStringCalculator : AbstractStringCalculator
    {
        public SumAbstractStringCalculator() { }

        public override double Calculate(String str)
        {
            List<double> d = (from String s in str.Split('+')
                               select double.Parse(s)).ToList();
            return d.Sum();
        }

    }
}

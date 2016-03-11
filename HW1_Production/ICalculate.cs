using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Production
{
    internal interface ICalculate
    {
        int[] Calculate(List<IProduct> data, string name, int number);
    }
}

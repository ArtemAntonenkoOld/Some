using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class CalculationInstanceFactory
    {
        private Factory GetInstance<T>(T item)
        {
            switch (typeof(item))
            {
                case Double.getType():
                    return;
                default:
                    throw new ArgumentOutOfRangeException("T");
            }
        }
    }
}

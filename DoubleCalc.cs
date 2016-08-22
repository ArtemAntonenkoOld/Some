using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class DoubleCalc : ICalc<double>
    {
        public Result<double> Summ(double val1, double val2)
        {
            Result<double> res = new Result<double>();
            try
            {
                res.val = val1 + val2;
            }
            catch
            {
                Console.WriteLine("Error");
                break;
            }
            return res;
            }
    }
}

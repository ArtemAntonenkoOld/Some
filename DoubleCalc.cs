using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class DoubleCalc : ICalc<double>
    {
        public Result<double> Summ(double val1, double val2)
        {
            Result<double> res = new Result<double>();
            try
            {
                res.Value = val1 + val2;
            }
            catch
            {
                res.Error = true;
                res.ErrorMessage = "Ошибка при выполнении операции";
            }
            return res;
        }
    }
}
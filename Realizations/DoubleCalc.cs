using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class DoubleCalc : ICalc<double>
    {
        private double val1;
        private double val2;

        public double Val1
        {
            set
            {
                val1 = value;
            }
        }

        public double Val2
        {
            set
            {
                val2 = value;
            }
        }

        public DoubleCalc(double val1, double val2) { Val1 = val1; Val2 = val2; }

        public Result<double> Summ()
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
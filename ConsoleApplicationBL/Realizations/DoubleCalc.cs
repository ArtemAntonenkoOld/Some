using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Calcitem<TType>
    {
        public double Val1 { get; set; }
        public double Val2 { get; set; }
    }

    public class CalculationItemEmptyException<T> : Exception
    {
        ICalc<T> _exceptionInstance = null;
        public ICalc<T> ExceptionInstance
        {
            get
            {
                return _exceptionInstance;
            }
        }
        public CalculationItemEmptyException(ICalc<T> exceptionInstance) : base()
        {

        }
    }

    public class DoubleCalc : ICalc<double>
    {

        public Calcitem<double> _calculationItem;

        public Result<double> Summ()
        {
            Result<double> res = new Result<double>();
            if (_calculationItem == null)
            {
                throw new CalculationItemEmptyException<double>(this);
            }
            try
            {
                res.Value = _calculationItem.Val1 + _calculationItem.Val2;
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
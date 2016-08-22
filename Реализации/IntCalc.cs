using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class IntCalc : ICalc<int>
    {
        private int val1;
        private int val2;

        public int Val1
        {
            set
            {
                val1 = value;
            }
        }

        public int Val2
        {
            set
            {
                val2 = value;
            }
        }
        public Result<int> Summ()
        {
            Result<int> res = new Result<int>();
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
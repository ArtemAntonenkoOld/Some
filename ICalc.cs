using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public interface ICalc<T>
    {
        Result<T> Summ(T val);
        string poslat();
    }
}

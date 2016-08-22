using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Result<T>
    {
        T Value;
        bool error;
        string errorMessage;
    }
}

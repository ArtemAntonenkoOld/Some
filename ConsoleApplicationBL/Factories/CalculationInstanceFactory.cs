using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
 
    //struct TypeConfig 
    //{
    //    static Dictionary<Types,Tuple<Type>> 
    //}
    class CalculationInstanceFactory
    {

        public static new Type GetType()
        {
            Console.WriteLine("Укажите тип");
            string t = Console.ReadLine();
            switch (t)
            {
                case "integer": return typeof(int);
                case "double": return typeof(double);
                default: throw new ArgumentOutOfRangeException("Wrong type!");
            }
        }

        public ICalc<TType> GetInstance<TType>(TType item)
        {
            ICalc<TType> result = null; 
            if (item.GetType() == typeof(Double))
            {
                DoubleCalc calc = new DoubleCalc();
                return (ICalc<TType>)calc;
                //return calc as ICalc<TType>;

            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public enum Types { Int, Double };

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

        public static object GetInstance(Types item)
        {
            
            switch (item)
            {
                
                case Types.Double:
                Console.WriteLine("Введите значения");
                DoubleCalc o = new DoubleCalc(
                Convert.ToDouble(Console.ReadLine()), 
                Convert.ToDouble(Console.ReadLine())
                );
                    return o.Summ();

                case Types.Int:
                Console.WriteLine("Введите значения");
                IntCalc p = new IntCalc(
                Convert.ToInt16(Console.ReadLine()),
                Convert.ToInt16(Console.ReadLine())
                );
                    return p.Summ();

                default:
                    throw new ArgumentOutOfRangeException("T");
            }
        }
    }
}

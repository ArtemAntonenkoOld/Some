using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    [Serializable]
    class SerializeModel
    {
        
        
            public double Number2 { get; set; }
            public double Number1 { get; set; }
            public char Operation { get; set; }
            public double Answer { get; set; }

            public SerializeModel(double number1, double number2, char operation, double answer)
            {
                Number1 = number1;
                Number2 = number2;
                Operation = operation;
                Answer = answer;

            }
        }
    }

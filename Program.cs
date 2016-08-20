using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SUPER\Documents\Visual Studio 2015\Projects\ConsoleApplication5\ConsoleApplication5\note.txt";
            Serialize s = new Serialize();
            
            try
            {
                
                var a = Convert.ToDouble(Console.ReadLine());
                s.NewData(path,a);
                s.EndData(path);
            }
            catch (Exception e)
            {
                s.ExeptionData(path, e.Message);
            }

        }
    }
}

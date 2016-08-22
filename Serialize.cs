using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Serialize
    {
        public void NewData(string path,double a)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                
                
                sw.Write(a);
            }
        }
        public void ExeptionData(string path, string a)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {


                sw.WriteLine(a);
            }
        }
        public void EndData(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {


                sw.WriteLine();
            }
        }


    }

}

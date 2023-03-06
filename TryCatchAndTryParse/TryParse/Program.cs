using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "5"; ;
            int a;

            bool result = int.TryParse(str, out a);

            Console.WriteLine("num is = "+(a+2)+"\nsymbol is "+ str);
            Console.ReadKey();


        }
    }
}

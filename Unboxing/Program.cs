using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//unboxing is process of converting reference type to   value type

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign value to int type
            int i = 100;
            //boxing it
            object o = i;

            //unboxing it
            int j = (int)o;


            //display result
            Console.WriteLine(o);
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}

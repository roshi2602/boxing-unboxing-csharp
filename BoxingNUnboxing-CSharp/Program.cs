using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Converting a value type to a reference type is called called boxing 
//int x =10;  //value type
//object o =x; //conversion of value type to reference type
//here o is refernce type
namespace BoxingNUnboxing_CSharp
{
    class Program
    {
        static void Main()
        {
            int i = 10;  //value type
            object o = i; //conversion to reference type

            //now change value of i  
            i = 20;
            Console.WriteLine(@"{0}", i);
            Console.WriteLine(@"{0}", o);
            Console.ReadLine();

        }
    }
}

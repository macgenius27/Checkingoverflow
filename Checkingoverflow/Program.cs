using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkingoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
           short s = 900;
            byte val = checked(byte)s;
          
            Console.WriteLine("{0}",s);
            Console.ReadKey();



        }
         checked{
               short sd = 900;
            byte val1 = checked(byte)sd;
               unchecked{}
           
           }
    }
}

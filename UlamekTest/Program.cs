using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamekLib;

namespace UlamekTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(0.1 + 0.2 == 0.3);
            
            Ulamek u = new Ulamek();
            Console.WriteLine(u);
            Ulamek v = new Ulamek(2, 10);
            Console.WriteLine(v);
            Ulamek w = new Ulamek(3, 10);
            //Console.WriteLine(u + v == w);
            
        }
    }
}

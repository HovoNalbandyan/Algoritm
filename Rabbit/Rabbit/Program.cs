using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            
            Console.WriteLine(Fibonachi(n));
        }
        static int Fibonachi(uint n)
        {
            if (n <= 2) return 1;else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
       
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M=");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Multy(n,m));
        }
        static int Multy(int n,int m)
        {

            if (n> 0)
            {
                return (m + Multy(n-1, m));
                
            }
            return 0;
           
        }

    }
}

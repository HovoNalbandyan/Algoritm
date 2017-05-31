using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M=");
            int m = int.Parse(Console.ReadLine());
            Devides(n, m); 
        }
        public static void Devides(int n,int m)
        {
            for (int i = 2; i < (n + m) / 2; i++)
            {
                if ((n % i == 0) && (m % i == 0))
                {
                    Console.WriteLine(i);
                }                  
                              
            }
        }
    }
}

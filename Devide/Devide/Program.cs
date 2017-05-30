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
        public static void Devides(int n,int m,int i=2)
        {
            
            while ((n % i == 0) && (m % i == 0)  )
                if ((i <= n / 2) && (i <= m / 2))
                {
                    Console.WriteLine(i);
                    ++i;
                    Devides(n, m,i++);
                }
                else
                 {
                 Devides(n, m,i++);++i;
                 }
            

        }
    }
}

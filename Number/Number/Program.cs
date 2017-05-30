using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Number(n));
        }
        static int Number(int n)
        {
          while (n>9)
            {
                return (1 + Number(n / 10));
            }
            return 1;


        }
    }
}

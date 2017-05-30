using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySurch
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var size = rnd.Next(6, 24);
            var a = new int[size];
            Console.WriteLine($"Size = {size}");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
            }
            Array.Sort(a);
            foreach (var x in a)
            {
                Console.Write($"{x}\t");
            }

            Console.ReadKey();
        
    }
    }
}

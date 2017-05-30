using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.Write("N=");
                int n = int.Parse(Console.ReadLine());
                List<int> A = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    A.Add(n - i);
                    Console.Write(A[i]+"\t");
                }
                List<int> B = new List<int>();
                    
            }
            
        }
        static void ShowList(List<int> list)
        {
            if (List count==0)
                Console.WriteLine(  "Empty");
            foreach (int i in list)
            {
                Console.WriteLine(i+"\t");
            }
            Console.WriteLine();
        }
    }
}

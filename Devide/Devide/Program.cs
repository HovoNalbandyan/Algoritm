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
        public static int Devides(int n,int m)
        {
            if (n>m)
            {
                if (n%m==0)&&
                {

                }
            }





            int i = 2;
            if ((n % i == 0) && (m % i == 0))
            {
                return Devides(n, m);  
                i++;
            }
            else { return 0; i++; Devides(n, m); }
           
            
        }
    }
}

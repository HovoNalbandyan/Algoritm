using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Armen";
            Book(s);
        }
        static void Book(string s)
        {
            int count = 0;
            if (s.Length >= 1)
            {
                string s1 = s.Substring(0, s.Length - 1);
                Console.Write(s[s.Length - 1]);
                Book(s1);
            }



        }
    }
}

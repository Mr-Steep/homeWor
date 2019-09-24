using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class task3
    {
        public static void GO()
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();

            char[] trs = str.ToArray();
            Array.Reverse(trs);
            string output = new string(trs);
            Console.WriteLine(trs);

            if (Enumerable.SequenceEqual(trs, trs.Reverse().ToArray()))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
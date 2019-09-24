using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class task2
    {
        public static void GO()
        {
            Console.WriteLine("Enter Size Mass A : ");
            var M = Console.ReadLine();
            int m = int.Parse(M);

            Console.WriteLine("Enter Size Mass B : ");
            var N = Console.ReadLine();
            int n = int.Parse(N);

            int[] A = new int[m];
            int[] B = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Your First Mass A: ");
            for (int i = 0; i < m; i++)
            {
                A[i] = rnd.Next(50);
                Console.Write(A[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

            Console.WriteLine("Your Second Mass B: ");
            for (int i = 0; i < n; i++)
            {
                B[i] = rnd.Next(50);
                Console.Write(B[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
            int Size1 = 0;
            if (m > n)
            {
                Size1 = m;
            }
            else Size1 = n;

            Console.WriteLine("Yout 3 mass");

            int[] C = A.Intersect(B).ToArray();

            foreach (int el in C)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}

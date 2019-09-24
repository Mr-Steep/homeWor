using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class task1
    {
        public static void GO()
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            int Max_A = 0, Sum_A = 0, proiz_A = 1, sumChet = 0;
            double Max_B = 0, Sum_B = 0, Proiz_B = 1, sunNechetStolb = 0;
            Random rnd = new Random();

            Console.WriteLine("Enter 5 num");

            for (int i = 0; i < 5; i++)
            {
                var a = Console.ReadLine();
                A[i] = int.Parse(a);
                if (Max_A < A[i])
                {
                    Max_A = A[i];
                }
                Sum_A += A[i];
                proiz_A *= A[i];

                if (A[i] % 2 == 0)
                {
                    sumChet += A[i];
                }



            }

            Console.WriteLine("Your First Mass: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i]);
                Console.Write(" ");

            }
            Console.WriteLine();
            Console.WriteLine("Max element mas A: ");
            Console.Write(Max_A);
            Console.WriteLine();
            Console.WriteLine("Sum element mas A: ");
            Console.Write(Sum_A);
            Console.WriteLine();
            Console.WriteLine("Proiz element mas A: ");
            Console.Write(proiz_A);
            Console.WriteLine();
            Console.WriteLine("Sum chet element mas A: ");
            Console.Write(sumChet);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your Second Mass: ");


            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 4; l++)
                {
                    B[i, l] = rnd.NextDouble() * 10;
                    Console.Write(" ");
                    Console.Write("{0:0.##}", B[i, l]);
                    Sum_B += B[i, l];
                    Proiz_B *= B[i, l];
                    if (Max_B < B[i, l])
                    {
                        Max_B = B[i, l];
                    }

                    if (l % 2 == 0)
                    {
                        sunNechetStolb += B[i, l];
                    }


                }
                Console.WriteLine();
            }

            Console.WriteLine("Max element mas B: ");
            Console.Write("{0:0.##}", Max_B);
            Console.WriteLine();
            Console.WriteLine("Sum element mas B: ");
            Console.Write("{0:0.##}", Sum_B);
            Console.WriteLine();
            Console.WriteLine("Proiz element mas B: ");
            Console.Write("{0:0.##}", Proiz_B);
            Console.WriteLine();
            Console.WriteLine("Summa Nechetnix Stolbov mas B: ");
            Console.Write("{0:0.##}", sunNechetStolb);
            Console.WriteLine();

        }
    }
}
        
    


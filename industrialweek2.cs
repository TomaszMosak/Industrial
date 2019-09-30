using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpweek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRST EXERCISE
            ulong a = 10;
            ulong b = 26;
            commondevisor(a, b); //woo
            Console.WriteLine("Euclid’s greatest common divisor algorithm");
            Console.Write("Inputs:");
            Console.Write(a);
            Console.Write(",");
            Console.WriteLine(b);
            Console.Write("Answer:");
            Console.WriteLine(commondevisor(a, b));
            //END FIRST EXERCISE


            //SECOND EXERCISE
            int[,] A = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] B = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            matrixmult(A, B);
            int[,] D = matrixmult(A, B);
            Console.WriteLine("Matrix Multiplication");
            Console.WriteLine("Printing Matrix: ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", A[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.WriteLine("Printing Matrix: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", B[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.WriteLine("Answer:");
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", D[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            //END SECOND EXERCISE

            //THIRD EXERCISE
            
            //END THIRD EXERCISE

        }
        private static ulong commondevisor(ulong a, ulong b) //FIRST EXERCISE
        {
            while (a != 0 && b != 0) // both have to have a value
            {
                if (a > b) // as long as a is greater than b do...
                {
                    a %= b; // a mod b
                }
                else // if the above if condition isnt met do this
                {
                    b %= a; // b mod a
                }
            }
            return a == 0 ? b : a; // condition ? consequent : alternative

        } //FIRST EXERCISE

        private static int[,] matrixmult(int[,] A, int[,] B)
        {

            int[,] C = new int[A.GetLength(0), B.GetLength(1)]; //find the amount of multiplications required
            if (A.GetLength(0) != B.GetLength(1)) //
                return null;

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        sum += C[i, j] + A[i, k] * B[k, j];
                    }

                    C[i, j] = sum;


                }

            }
            return C;
        }
    }
}


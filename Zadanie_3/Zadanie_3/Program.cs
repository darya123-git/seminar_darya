using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]A={5,6,9,8,7,3};
            Console.WriteLine("Элементы массива, начиная с конца:");
            PrintArray(A, A.Length-1);
            Console.ReadLine();
        }

        static void PrintArray(int[] B, int i)
        {
            if (i>=0)
            {
                Console.Write(B[i]+" ");
                PrintArray(B,i-1);
            }
        }

    }
}
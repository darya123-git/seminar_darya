using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите неотрицательное число m: "); 
            int m=int.Parse(Console.ReadLine()); 
            Console.Write("Введите неотрицательное число n: "); 
            int n=int.Parse(Console.ReadLine()); 
            int result=Ackermann(m, n); 
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Ackermann(int m, int n)
        { 
            if (m==0) 
                return n+1; 
            else if (n==0) 
                return Ackermann(m-1, 1); 
            else 
                return Ackermann(m-1, Ackermann(m, n-1)); 
        } 
    }
}
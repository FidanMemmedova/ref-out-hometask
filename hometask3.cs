using System;

namespace ConsoleApp3
{
    class Program
    {
         static void Main(string[] args)
         {
            int num = 36;
            Squareroot(ref num);
         }

        static void Squareroot(ref int n)
        {
            int a = 1;
            while (a * a <= n)
            {
                a++;
            }
            n = a - 1;
            Console.WriteLine(n);

        }
    }
}


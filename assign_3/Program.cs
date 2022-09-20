using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arrey = new int[25];

            int n1 = 0; int n2 = 1; int num = 0;

            Arrey[0] = n1;
            Arrey[1] = n2;

            for (int i = 2; i < Arrey.Length; i++)
            {
                num = n1 + n2;

                Arrey[i] = num;

                n1 = n2;
                n2 = num;
            }


            for (int i = 0; i < Arrey.Length; i++)
            {
                Console.WriteLine($"Fibonacci number({i}) = {Arrey[i]}");
            }

            Console.ReadLine();
        }
    }
}

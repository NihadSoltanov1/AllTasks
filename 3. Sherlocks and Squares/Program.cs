using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sherlocks_and_Squares
{
    internal class Program
    {
        public static int Squares(int n1, int n2)
        {
            int count = 0;
            int i = 1;
            int square = 1;
            while (square <= n1)
            {

                if (square >= n2)
                {
                    count++;
                }
                i++;
                square = i * i;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //Enter the Numbers
            Console.Write("Enter The Number 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Number 2: ");
            int n2 = int.Parse(Console.ReadLine());

            //Result
            Console.Write("Resut: " + Squares(n1, n2));
            Console.Read();
        }
    }

}

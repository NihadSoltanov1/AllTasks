using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Grading_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter the number of students
            Console.Write("Number of Students:");
            int c = int.Parse(Console.ReadLine());
            int[] degrees = new int[c];

            for (int i = 0; i < degrees.Length; i++)
            {
                // Enter the all degrees
                Console.Write($"{i + 1}. Degree of Student: ");
                int degree = int.Parse(Console.ReadLine());
                if (degree <= 100 && degree >= 0) {
                    // Round the degree if necessary
                    if (degree >= 38 && degree % 5 >= 3)
                    {
                        degree = degree + (5 - (degree % 5));
                    }

                    degrees[i] = degree;

                }
               
            }
            // Print the final degree of students
            foreach (var degree in degrees)
            {
                Console.WriteLine($"Final Degree: {degree}");
            }
            Console.ReadLine();
        }
    }
}

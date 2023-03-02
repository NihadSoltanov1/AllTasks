using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Save_the_Prisoners
{
    internal class Program
    {
       public static int findBadTastingPlace(int numberOfPrisoners, int numberOfTreats, int startPlace)
        {
            int badTasting = (startPlace + numberOfTreats - 1) % numberOfPrisoners;

            // check if the result equals zero, last prisoner will accept the bad tasting candy.
            if (badTasting == 0)
            {
                badTasting = numberOfPrisoners;
            }

            return badTasting;
        }
        static void Main(string[] args)
        {
            //Enter the Number of Prisoners
            Console.Write("Enter the Number of Prisoners: ");
            int numberOfPrisoners = int.Parse(Console.ReadLine());

            //Enter the Number of Treats
            Console.Write("Enter the Number of Treats: ");
            int numberOfTreats = int.Parse(Console.ReadLine());

            //Enter the start place
            Console.Write("Enter the start place: ");
            int startPlace = int.Parse(Console.ReadLine());

            //Result
            Console.WriteLine($"{findBadTastingPlace(numberOfPrisoners, numberOfTreats, startPlace)}. Prisoners eat the bas tasting candy.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Birthday_Cake_Candles
{
    internal class Program
    {
        public static int birthdayCakeCandles(int[] candles)
        {
            int maxLength = 0;
            int countCandles = 0;

            //Find the biggest the tallest candle and count
            foreach (int candle in candles)
            {
                //The tallest candle
                if (candle > maxLength)
                {
                    maxLength = candle;
                    countCandles = 1;
                }
                //Number of the tallest candle
                else if (candle == maxLength)
                {
                    countCandles++;
                }
            }
            return countCandles;
        }

        static void Main(string[] args)
        {
            //Enter the total age of child
            Console.Write("Enter age of child: ");
            int totalAge = int.Parse(Console.ReadLine());
            int[] candles = new int[totalAge];

            //Enter the candles size 
            for (int i = 0; i < candles.Length; i++)
            {
                Console.Write($"{i + 1}. Candle Length: ");
                candles[i] = int.Parse(Console.ReadLine());
            }

            //Run The Function
            Console.Write(birthdayCakeCandles(candles));
            Console.Read();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int[] HistogramArray = new int[10];

            while (true)
            {   //input
                Console.WriteLine("Please enter a grade between 0 and 100");
                input = GetNumberInRange(-1, 100);

                if (input == -1)
                    break;

                //process
                int index = input / 10;

                if (index == 10)

                    index = index - 1;

                HistogramArray[index]++;
            }

            int maxValue1 = HistogramArray.Max();
            int maxValue2 = HistogramArray.Max();

            // output:

            for (int i = 0; i < maxValue2; i++)
            {
                for (int p = 0; p < 10; p++)
                {
                    
                    if (HistogramArray[p] != maxValue1)
                    {
                        Console.Write("\t");
                        Console.Write(" ");
                    }

                    if (HistogramArray[p] == maxValue1)
                    {
                        //string str = new string('*', HistogramArray[p]);
                        Console.Write("\t");
                        Console.Write("*");
                        HistogramArray[p]--;
                    }
                }
                maxValue1--;
                Console.WriteLine();
            }
            Console.WriteLine("\t 0-9\t10-19\t20-29\t30-39\t40-49\t50-59\t60-69\t70-79\t80-89\t90-100");
        }

        public static int GetValidInteger()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }
            return input;
        }

        //Validates that integer is within a given range
        public static int GetNumberInRange(int min, int max)
        {
            int input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInteger();
            }
            return input;
        }
    }
}


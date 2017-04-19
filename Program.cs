using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidInt_and_Range
{
    class Program
    {
        static void Main(string[] args)
     

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    internal class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            int biggestNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            return biggestNumber;

        }
       
        public static int SecondBiggestNumber(int[] numbers)
        {
            int biggestNumber = BiggestNumber(numbers);
            int secondbiggestNumber = numbers[0];

            foreach (int number in numbers)
            {
                if ((number > secondbiggestNumber) && (number < biggestNumber))
                {
                    secondbiggestNumber = number;
                }
            }

            return secondbiggestNumber;
        
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace IsHappy
{
    static class HappyNumbers
    {
        public static bool IsHappyNumber(int number)
        {

            bool isHappy = check_is_One(number);
            if (isHappy)
            {
                return true;
            }

            List<int> nums = splitt_Digits(number);
            nums = square(nums);
            int sum = sumNums(nums);
            bool check = check_for_termination(sum);
            if (!check)
            {
                
            }
            return false;
        }



        public static int[] splitt_Digits(int value)
        {
            int size = DetermineDigitCount(value);
            int[] digits = new int[size];
            for (int index = size - 1; index >= 0; index--)
            {
                digits[index] = value % 10;
                value = value / 10;
            }
            return digits;
        }

        private static bool check_is_One(int number)
        {
            return number == 1 ? true : false;

        }
    }













    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

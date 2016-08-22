using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace IsHappy
{
    public static class HappyNumbers
    {


        public static void IsHappyNumber(int number)
        {
            CheckIsHappyUnhappy(number);
        }

        public static void ResultFound(bool result)
        {
            OnCheckDone(result);
        }


        public static event Action<bool> OnCheckDone;

        public static void CheckIsHappyUnhappy(int number)
        {
            IF_Is_HappyNumber(number, 
                ResultFound, 
                CreateNextNumber);
        }

        private static void CreateNextNumber(int number)
        {
            Debug.WriteLine(number.ToString());
            IEnumerable<int> digits = SplitDigits(number).ToList();
            digits = digits.Select(x => (int) Math.Pow(x, 2));
            int sum = digits.Sum();

            CheckIsHappyUnhappy(sum);
        }

        private static void IF_Is_HappyNumber(int number, Action<bool> ResultFound, Action<int> checkNumber)
        {
            switch (number)
            {
                case 1:
                    ResultFound(true);
                    return;
                case 4:
                    ResultFound(false);
                    return;
                default:
                    checkNumber(number);
                    return;
            }
        }

        public static IEnumerable<int> SplitDigits(int number)
        {
            var chars = number.ToString().ToCharArray();
            foreach (var c in chars)
            {
                yield return int.Parse(c.ToString());
            }
        }

    }













    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

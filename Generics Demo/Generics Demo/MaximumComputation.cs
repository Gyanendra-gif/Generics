using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Demo
{
    class MaximumComputation
    {
        public static int MaxNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum > thirdNum)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum > thirdNum)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
        public static double MaximumNumber(double firstNumb, double secondNumb, double thirdNumb)
        {
            if (firstNumb.CompareTo(secondNumb) > 0 && firstNumb > thirdNumb)
            {
                return firstNumb;
            }
            if (secondNumb.CompareTo(firstNumb) > 0 && secondNumb > thirdNumb)
            {
                return secondNumb;
            }
            else
            {
                return thirdNumb;
            }
        }
        public static string MaximumString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
            {
                return secondString;
            }
            else
            {
                return thirdString;
            }
        }
    }
}

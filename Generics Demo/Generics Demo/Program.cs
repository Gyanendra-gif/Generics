using System;

namespace Generics_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Generics Program Press- 1-Maximum Integer Num., 2-Maximum Float Num, 3-Maximum String, 4-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Three Numbers to Check Max.");
                        int firstNum = Convert.ToInt32(Console.ReadLine());
                        int secondNum = Convert.ToInt32(Console.ReadLine());
                        int thirdNum = Convert.ToInt32(Console.ReadLine());
                        int outPut = MaximumComputation.MaxNumber(firstNum, secondNum, thirdNum);
                        Console.WriteLine("Max Number is: "+outPut);
                        break;
                   case 2:
                        Console.WriteLine("Enter Three Float Numbers to Check Max.");
                        double firstNumb = Convert.ToDouble(Console.ReadLine());
                        double secondNumb = Convert.ToDouble(Console.ReadLine());
                        double thirdNumb = Convert.ToDouble(Console.ReadLine());
                        double result = MaximumComputation.MaximumNumber(firstNumb, secondNumb, thirdNumb);
                        Console.WriteLine("Max Number is: " + result);
                        break;
                    case 3:
                        Console.WriteLine("Enter Three Float Numbers to Check Max.");
                        String firstString = Convert.ToString(Console.ReadLine());
                        String secondString = Convert.ToString(Console.ReadLine());
                        String thirdString = Convert.ToString(Console.ReadLine());
                        String res = MaximumComputation.MaximumString(firstString, secondString, thirdString);
                        Console.WriteLine("Max Number is: " + res);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}


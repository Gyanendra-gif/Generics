﻿using System;

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
                }
            }
        }
    }
}


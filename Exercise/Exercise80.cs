using System;
namespace Exercise
{
    public static class Exercise80
    {
        public static void swapTwoDigitNumsAndCheckCondition()
        {
            Console.Write($"Enter a two digit number: ");
            int num = int.Parse(Console.ReadLine());

            int divide, rem, temp = num;
            string ReverseNum = "";

            while(temp > 0)
            {
                rem = temp % 10;
                ReverseNum += rem;
                divide = temp / 10;
                temp = divide;  
            }
            Console.WriteLine($"Swap Value: {ReverseNum}");
            if(Convert.ToInt32(ReverseNum) < num)
            {
                Console.WriteLine($"Is Greater Than Swap Value: {Convert.ToInt32(ReverseNum) < num}");
            }
            else
            {
                Console.WriteLine($"Is Greater Than Swap Value: {Convert.ToInt32(ReverseNum) < num}");
            }
        }
    }
}
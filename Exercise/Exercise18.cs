namespace Exercise
{
    //Program to check two integers if one is positive and one is negative return True
    public static class Exercise18
    {
        public static void CheckNegativeAndPositive()
        {
            int num1, num2;
            Console.WriteLine($"=========Taking Input========");
            Console.Write($"Enter the 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter the 2: ");
            num2 = int.Parse(Console.ReadLine());

            if((int.IsPositive(num1) && int.IsNegative(num2)) || (int.IsPositive(num2) && int.IsNegative(num1))){
                Console.WriteLine($"Problem 18: True");
            }
            else{
                Console.WriteLine($"Problem 18: False");
            }
            
        }
    }
}
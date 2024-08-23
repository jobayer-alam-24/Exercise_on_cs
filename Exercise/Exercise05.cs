namespace Exercise
{
    //Program to swap two numbers
    public static class Exercise05
    {
        public static void SwapTwoNumbers()
        {
            int num1 = 5, num2 = 6, temp;
            Console.WriteLine($"Before Swapping: number1 = {num1}, number2 = {num2}");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After Swapping: number1 = {num1}, number2 = {num2}");
        }
    }
}
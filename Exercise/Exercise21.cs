namespace Exercise
{
    //Program to check the sum of the two given integers
    public static class Exercise21
    {
        public static void CheckTheSumOfTwoGivenNumbers()
        {
            int num1, num2, sum;
            Console.WriteLine($"========Taking Input======");
            Console.Write($"Enter num 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter num 2: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            if(sum == 20 || num1 == 20 || num2 == 20){
                Console.WriteLine($"Result: True");
            }
            else{
                Console.WriteLine($"Result: False");
            }

        }
    }
}
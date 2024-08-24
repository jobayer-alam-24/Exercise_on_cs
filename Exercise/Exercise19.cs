namespace Exercise
{
    //Program to find out sum of 2 integers But if two values are the same return the triple of their sum
    public static class Exercise19
    {
        public static void CheckGivenCondition()
        {
            int num1, num2;
            Console.WriteLine($"====Taking Input====");
            Console.Write($"Enter the num - 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter the num - 2: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2){
                Console.WriteLine($"Sum X 3: {(num1 + num2) * 3}");
            }
            else{
                Console.WriteLine($"Sum: {num1 + num2}");
            }
        }
    }
}
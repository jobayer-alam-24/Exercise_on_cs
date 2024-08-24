namespace Exercise
{
    //Program to make negative to absolute value
    public static class Exercise20
    {
        public static void WorkOnAbsoluteValue()
        {
            int num1, num2;
            Console.WriteLine($"====Taking Input====");
            Console.Write($"Enter the num - 1: ");
            num1 =  int.Parse(Console.ReadLine());
            Console.Write($"Enter the num - 2: ");
            num2 =  int.Parse(Console.ReadLine());

            int abs = Math.Abs(num1 - num2);
            if(num1 < num2){
                Console.WriteLine($"Absolute Value Of Difference: {abs}");
            }
            else if(num1 > num2){
                Console.WriteLine($"Double of absolute difference: {abs * 2}");
            }
        }
    }
}
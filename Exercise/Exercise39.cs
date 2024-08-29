namespace Exercise
{
    //Program to find the largest and lowest value of 3
    public static class Exercise39
    {
        public static void LargestLowest()
        {
            int num1, num2, num3;
            Console.WriteLine($"======Taking Input========");
            Console.Write($"Enter num 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter num 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write($"Enter num 3: ");
            num3 = int.Parse(Console.ReadLine());
            largestOne(num1, num2, num3);
            lowestOne(num1, num2, num3);

        }
        public static void largestOne(int n1, int n2, int n3)
        
        {
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"Largest: {n1}");
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"Largest: {n2}");
            }
            else
            {
                Console.WriteLine($"Largest: {n3}");
            }
        }
        public static void lowestOne(int n1, int n2, int n3)
        {
            if(n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"Lowest: {n1}");
            }
            else if(n2 < n1 && n2 < n3)
            {
                Console.WriteLine($"Lowest: {n2}");
            }
            else
            {
                Console.WriteLine($"Lowest: {n3}");
            }
        }
    }
}
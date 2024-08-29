namespace Exercise
{
    //Program to find the nearest value of 20
    public static class Exercise40
    {
        public static void NearestValueOfTwenty()
        {
            int n1, n2;
            Console.WriteLine($"======Taking Input========");
            Console.Write($"Enter num - 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter num - 2: ");
            n2 = int.Parse(Console.ReadLine());
            
            int longest = LongestValue(n1, n2);
            if(longest < 20)
            {
                Console.WriteLine($"Nearest Value Of Twenty: {longest}");
            }
           
        }
        public static int LongestValue(int n1, int n2)
        {
            if(n1 == n2) return 0;
            if(n1 > n2) return n1;
            else return n2;
        }
    }
}
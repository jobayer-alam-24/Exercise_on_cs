namespace Exercise
{
    //Program to check an odd Number inside an array
    public static class Exercise53
    {
        public static void CheckOdd()
        {
            int[] num = {2, 4, 1, 8, 6};
            int len = num.Length;
            PrintWithSign(num, len);
            HasOdd(num);
        }
        private static void PrintWithSign(int[] num, int len)
        {
            Console.Write($"Array -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(num[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
        private static void HasOdd(int[] nums)
        {
            bool stop = false;
            foreach(int i in nums)
            {
                if(i % 2 == 1)
                {
                    stop = true;
                    break;
                }
            }
            string messege = stop ? "It contains Odd." : "It does not contain Odd";
            Console.WriteLine(messege);
        }
    }
}
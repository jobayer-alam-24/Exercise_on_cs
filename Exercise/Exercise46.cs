namespace Exercise
{
    //Program to find first and last elements of array from given integer
    public static class Exercise46
    {
        public static void IsAppearsInFirstOrLast()
        {
            int num, len;
            int[] dataBase = {1, 2, 3, 4, 5, 1};
            len = dataBase.Length;
            printArray(dataBase, len);
            Console.Write($"Enter the num you want to find in first and last chars: ");
            num = int.Parse(Console.ReadLine());

            if(dataBase[0] == num || dataBase[len - 1] == num)
            {
                Console.WriteLine($"Found {num} in first or last.");
            }
            else 
            {
                Console.WriteLine($"Not Found {num} in first or last");
            }

        }
        private static void printArray(int[] array, int len)
        {
            
            Console.Write($"Data Base -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(array[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
    }
}
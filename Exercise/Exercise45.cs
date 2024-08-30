namespace Exercise
{
    //Program to count a specified number in an array
    public static class Exercise45
    {
        public static void CountNumberPresentInArray()
        {
            int count = 0, num;
            int[] dataBase = {1, 2, 5, 4, 5, 6, 5, 5}; 
            PrintArray(dataBase);
            Console.Write($"Enter the number you want to Find: ");
            num = int.Parse(Console.ReadLine());

            foreach(int i in dataBase){
                if(i == num)
                {
                    count++;
                }
            }

            if(count == 0)
            {
                Console.WriteLine($"Error: Not Found!");
            }
            else
            {
                Console.WriteLine($"{num} Found {count} times.");
            }
        }
        private static void PrintArray(int[] array)
        {
            int len = array.Length;
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
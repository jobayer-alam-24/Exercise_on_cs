namespace Exercise
{
    //Program to print how many numbers are not present inside a specific range of Array
    public static class Exercise58
    {
        public static void AbsentNumbersInsideArray()
        {
            int start, end, inputNums, count = 0;

            Console.WriteLine($"=======Taking Input=========");
            Console.Write($"Enter the starting point: ");
            start = int.Parse(Console.ReadLine());
            Console.Write($"Enter the ending point: ");
            end = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine($"================");
            Console.Write($"How many numbers do you want to give between {start}-{end}: ");
            inputNums = int.Parse(Console.ReadLine());
            Console.Beep();
            int[] list_Of_numbers = new int[inputNums];
            for (int i = 0; i < inputNums; i++)
            {
                Console.Write($"Enter num {i + 1}: ");
                list_Of_numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Beep();
            for (int i = start; i <= end; i++)
            {
                if(list_Of_numbers.Contains(i) == false)
                {
                    count++;
                }
            }
            if(count != 0)
            {
                Console.WriteLine($"{count} numbers were not present in your lists.");
            }
            else 
            {
                Console.WriteLine($"All Numbers are Present!");
            }
        }
    }
}
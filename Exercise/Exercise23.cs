namespace Exercise
{
    //Program to convert string to lowercase
    public static class Exercise23
    {
        public static void StringToLowerCase()
        {
            Console.WriteLine($"==========Taking Input========");
            Console.Write($"Enter your name: ");
            string name = Console.ReadLine().ToLower();
            Console.WriteLine($"Lowercase = {name}");
        }
    }
}
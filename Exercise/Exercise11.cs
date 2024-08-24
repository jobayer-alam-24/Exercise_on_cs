namespace Exercise
{
    //Program to print messege on given Age
    public static class Exercise11
    {
        public static void PrintMessegeOnGivenAge()
        {
            int age;
            Console.WriteLine($"======Taking Input=======");
            Console.Write($"Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");
        }
    }
}
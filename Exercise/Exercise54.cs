namespace Exercise
{
    //Program to find the century of a given Year

    /*
        !------------Century Of Year-------------!
        ?? Formula - Year % 100 == 0, the century is Year / 100
        ?? Otherwise, the century is (Year / 100) + 1.
    */
    public static class Exercise54
    {
        public static void CenturyOfAGivenYear()
        {
            int year;
            Console.WriteLine($"======Taking Input=======");
            Console.Write($"Enter the Year: ");
            year = int.Parse(Console.ReadLine());

            if (year % 100 == 0)
            {
                int century = year / 100;
                Console.WriteLine($"{year} is in the {century}th Century.");
            }
            else
            {
                int century = (year / 100) + 1;
                Console.WriteLine($"{year} is in the {century}th Century.");
            }
        }
    }
}
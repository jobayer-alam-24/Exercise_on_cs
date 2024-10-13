namespace Exercise
{
    public static class Exercise78
    {
        public static void ConvertStringToIntAndIntToString()
        {
            Console.Write($"Enter an Integer (number): ");
            int intNum = int.Parse(Console.ReadLine());

            Console.Write($"Enter a number (string): ");
            string strNum = Console.ReadLine();

            Console.WriteLine($"Converted Number To string: {intNum}, {intNum.ToString().GetType()}");
            Console.WriteLine($"Converted String To Number: {strNum}, {Convert.ToInt32(strNum).GetType()}");
        }
    }
}
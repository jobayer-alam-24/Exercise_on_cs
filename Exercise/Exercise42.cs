namespace Exercise
{
    //Program on UPPERCASE & lowercase in certain condition
    public static class Exercise42
    {
        public static void UppercaseLowercase()
        {
            string input;
            Console.WriteLine($"=======Taking Input======");
            Console.Write($"Enter an string (1st Four Characters are in 'lowercase'): ");
            input = Console.ReadLine();

            //Counting letters in a string
            int lettersCount = input.Count(perLetter => char.IsLetter(perLetter));

            if(lettersCount > 4)
            {
                Console.WriteLine($"Default: {input}");
            }
            else
            {
                Console.WriteLine($"Uppercase: {input.ToUpper()}");
            }
        }
    }
}
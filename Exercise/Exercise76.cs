namespace Exercise
{
    public static class Exercise76
    {
        public static void PluralWordsCheck()
        {
            Console.Write($"Enter a word: ");
            string word = Console.ReadLine();

            string IsPlural = word.EndsWith('s') ? "Plural" : "Singular";
            Console.WriteLine($"{word} is {IsPlural}");
        }
    }
}
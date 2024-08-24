namespace Exercise
{
    //Program to add the first charater of a sentence at the front and back of the sentence
    public static class Exercise17
    {
        public static void CharacterAdd(string input)
        {
            char firstChar = input[0];
            Console.WriteLine($"{firstChar}{input}{firstChar}");
        }
    }
}
namespace Exercise
{
    //Program to check if a given string is a palindrome or not.
    public static class Exercise56
    {
        public static void PalindromeCheck()
        {
            string input, reverse = "";
            int lastIndex;

            Console.WriteLine($"===========Taking Input========");
            Console.Write($"Enter a string: ");
            input = Console.ReadLine();
            lastIndex = input.Length - 1;

            for(int i = lastIndex; i >= 0; i--)
            {
                reverse += input[i];
            }
            if(reverse == input)
            {
                Console.WriteLine($"Palindrome: True, {reverse} == {input}");
                Console.WriteLine($"Palindrome (Text): If a text is similar both in Forward and Backward Direction.");
            }
            else 
            {
                Console.WriteLine($"Palindrome: False, {reverse} != {input}");
                Console.WriteLine($"Palindrome (Text): If a text is similar both in Forward and Backward Direction.");
            }
        }   
    }
}
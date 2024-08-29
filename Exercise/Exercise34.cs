namespace Exercise 
{
    //Program to find if a String starts with specified word
    public static class Exercise34
    {
        public static void IsStartsWithHello(string txt)
        {
            if(txt.StartsWith("Hello"))
            {
                Console.WriteLine($"Exercise 34: True");
            }
            else
            {
               Console.WriteLine($"Exercise 34: False"); 
            }
        }
    }
}
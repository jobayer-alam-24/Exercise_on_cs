using System.Reflection.Emit;
namespace Exercise
{
    //Program to check following 2 w's
    public static class Exercise43
    {
        public static void CheckFollowing2Ws()
        {
            string txt = "ww tution";
            string print = txt.Substring(0, 3).Equals("ww ") ? "Exercise 43: True" : "Exercise 43: False";
            Console.WriteLine(print);
        }
    }
}
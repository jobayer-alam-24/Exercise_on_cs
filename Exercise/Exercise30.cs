using System;
namespace Exercise
{
    //Program to Convert Hexadecimal num TO decimal Num
    public static class Exercise30
    {
        public static void HexadecimalToDecimal(string hex)
        {
            int inputNumberBase = 16;
            //Base-> 2-Bin, 8-Octal, 10-Decimal, 16-Hexadecimal 
            int decimalNum = Convert.ToInt32(hex, inputNumberBase);
            Console.WriteLine($"Hex to Decimal: {decimalNum}");
        }
    }
}
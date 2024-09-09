using System.Net;
using System.IO;
using System.Security.Cryptography;
namespace Exercise
{
    // Program to get the file name (including extension) from a given path.
    public static class Exercise64
    {
        public static void PathToFileName()
        {
            string path = @"";
            //! @ Verbatim String Literal
            Console.Write($"Enter the file Path: ");   
            path = Console.ReadLine();

            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("Fil Name: " + fileInfo.Name);
        }
    }
}
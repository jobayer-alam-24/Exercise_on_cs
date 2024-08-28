namespace Exercise
{
    //Program to print the size of a File in Bytes
    public static class Exercise29
    {
        public static void FileSizeInBytesFromPC()
        {
          FileInfo info_of_file = new FileInfo("C:\\Users\\JOBAYER\\Downloads\\trsoye.png");
          long FileSize = info_of_file.Length;  

          Console.WriteLine($"File Size: {FileSize} Bytes");
        }
    }
}
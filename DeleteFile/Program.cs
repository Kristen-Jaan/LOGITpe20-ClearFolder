using System;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            FileDelete();
        }
        public static void FileDelete()
        {
            string rootPath = @"C:\Users\opilane\Samples\playerTwo";
            string fileName = "Balls.txt";

            if(File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted.");
            }else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

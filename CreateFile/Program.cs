using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            //CreateNewFile();
            Console.WriteLine("enter the file name: ");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithExtension(userInput);

        }

        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\opilane\Samples\playerOne";
            string fileName = "Balls.txt";
            File.Create(Path.Combine(rootPath, fileName));
        }

        public static void CreateUserFile(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\playerTwo";
            File.Create(Path.Combine(rootPath, fileName));
        }
        public static void CreateFileWithExtension(string fileName)
        {
            string rootPath = @"C:\Users\opilane\Samples\playerTwo";
            string fullfileName = $"{fileName}.txt";
            File.Create(Path.Combine(rootPath, fullfileName));
        }
    }
}

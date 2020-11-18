using System;
using System.IO;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            CreateFolderName();
            CreateFolderTwo();
        }
        public static void CreateFolderName()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerOne";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if(Directory.Exists(fullFolderPath)) //check if folder already exists
            {
                Console.WriteLine("The folder already exists.");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }

        }
        public static void CreateFolderTwo()
        {
            string rootPath = @"C:\Users\opilane\Samples";
            string folderName = "playerTwo";
            string fullFolderPath = Path.Combine(rootPath, folderName);
            Console.WriteLine(fullFolderPath);
            if(Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The folder already exists.");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
    }
}

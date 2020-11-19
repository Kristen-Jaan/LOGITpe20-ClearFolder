using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            MoveFile();

        }
        public static void MoveFile()
        {
            string sourceDirectory = @"C:\Users\opilane\Samples\playerOne";
            string destinationPath = @"C:\Users\opilane\Samples\playerTwo";
            string fileName = "Balls.txt";

            File.Move(Path.Combine(sourceDirectory, fileName), Path.Combine(destinationPath, fileName));
        }
    }
}

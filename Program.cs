using System;
using System.Collections.Concurrent;
using System.IO;

namespace FileIOOperatiion
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldExists();
            ReadAllLine();
            ReadAllText();
            FileCopy();
            DeleteFile();
        }
        /// <summary>
        /// Checks if the given path file exists 
        /// </summary>
        public static void FieldExists()
        {
            string path = "C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Method reads all the lines and store as array
        /// </summary>
        public static void ReadAllLine()
        {
            string path = @"C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            string[] Lines;
            Lines = File.ReadAllLines(path);
            Console.WriteLine(Lines[0]);
            Console.WriteLine(Lines[1]);
            Console.ReadKey();
        }
        /// <summary>
        /// Method Reads all the lines in file and store as text
        /// </summary>
        public static void ReadAllText()
        {
            string path = "C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        /// <summary>
        /// Method copies data from one file to another file
        /// </summary>
        public static void FileCopy()
        {
            Console.WriteLine("Copying");
            string path = "C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            string copyPath = @"C:\Users\Ravula\source\repos\FileIOOperatiion\Test2.txt";
            File.Copy(path, copyPath);
            Console.ReadKey();
        }
        /// <summary>
        /// Delete the file
        /// </summary>
        public static void DeleteFile()
        {
            Console.WriteLine("Deleting file..");
            string path = @"C:\Users\Ravula\source\repos\FileIOOperatiion\Test2.txt";
            File.Delete(path);
            Console.ReadKey();
        }
    }
}

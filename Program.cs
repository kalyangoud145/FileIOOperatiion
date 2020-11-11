﻿using System;
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
    }
}

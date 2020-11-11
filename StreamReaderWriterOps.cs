using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIOOperatiion
{
    class StreamReaderWriterOps
    {
        /// <summary>
        /// Writes the data using stream writer.
        /// </summary>
        public void WriteUsingStreamWriter()
        {
            string path = "C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine("operations using stream writer and reader");
                streamWriter.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Reads the data using stream reader.
        /// </summary>
        public void ReadUsingStreamReader()
        {
            Console.WriteLine("**Reading data from file**");
            string path = "C:/Users/Ravula/source/repos/FileIOOperatiion/example.txt";
            using (StreamReader streamReader = File.OpenText(path))
            {
                string text = "";
                while ((text = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}

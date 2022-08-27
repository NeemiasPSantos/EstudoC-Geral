using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\Neemi\Desktop\Programação\C#\Exemplos e testes\FilesExem4\myfolder";
            try
            {
                // É possivel usar "var" no lugar de "IEnumerable<string>"
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
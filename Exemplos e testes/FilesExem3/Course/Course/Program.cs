using System.IO;
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\Neemi\Desktop\Programação\C#\Exemplos e testes\FilesExem3\file.txt";
            try
            {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
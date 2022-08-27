using System.IO;
namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Neemi\Desktop\Programação\C#\Exemplos e testes\FilesExem2\file.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream)
                { 
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }               
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
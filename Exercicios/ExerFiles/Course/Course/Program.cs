using System;
using System.IO;
using System.Globalization;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\Users\Neemi\Desktop\Programação\C#\Exercicios\ExerFiles\file.txt";
            string folderFilepath = @"C:\Users\Neemi\Desktop\Programação\C#\Exercicios\ExerFiles\out";
            string finalPathFile = folderFilepath + @"\summary.csv";
            try
            {
                Directory.CreateDirectory(folderFilepath);
                string[] files = File.ReadAllLines(sourceFilePath);
                using (StreamWriter sw = File.AppendText(finalPathFile))
                {
                    foreach (string file in files)
                    {
                        string[] piece = file.Split(',');
                        string name = piece[0];
                        double price = double.Parse(piece[1], CultureInfo.InvariantCulture);
                        string excpt = piece[2];
                        int quantity = Int32.Parse(excpt);
                        
                        Products product = new Products(name, price, quantity);
                        sw.WriteLine(product.Name + ", $ " + product.TotalPrice().ToString("f2", CultureInfo.InvariantCulture));
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

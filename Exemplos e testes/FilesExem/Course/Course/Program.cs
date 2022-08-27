namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Neemi\Desktop\Programação\C#\Exemplos e testes\FilesExem\file.txt";
            string targetPath = @"C:\Users\Neemi\Desktop\Programação\C#\Exemplos e testes\FilesExem\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
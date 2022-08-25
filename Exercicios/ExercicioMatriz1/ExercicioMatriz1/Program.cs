namespace ExercicioMatriz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe informe o numero de linhas e colunas");

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Informe o numero da posição que deseja verificar: ");
            
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ": ");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1) 
                        {
                            Console.WriteLine("Down: " + matriz[i +1, j]);
                        }
                    }
                }
            }
        }
    }
}
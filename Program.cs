using System;

class Program
{
    static void Main(string[] args)
    {

        bool loop = true;

        do
        {
        Console.WriteLine("Enter '+' to add or '-' to subtract.");
        string operation = Console.ReadLine();
        Console.WriteLine();

        if (operation == "+" || operation == "-")
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double[,] matrix1 = new double[m, n];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (!double.TryParse(Console.ReadLine(), out matrix1[i, j]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            double[,] matrix2 = new double[m, n];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (!double.TryParse(Console.ReadLine(), out matrix2[i, j]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (operation == "+")
                    {
                        Console.Write(matrix1[i, j] + matrix2[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(matrix1[i, j] - matrix2[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();

        } 
        else 
        {
            loop = false;
        }
        }while (loop);
    }
}
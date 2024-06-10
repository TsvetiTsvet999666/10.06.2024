namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 3;
            double[,] matrix = new double[size, size];
            Console.WriteLine("Enter the elements of the 10x10 matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The elements of the main diagonal:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(matrix[i, i]);
                if (i < size - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine("The row sum matrix:");
            for (int i = 0; i < size; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j],8:F2} ");
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"| Сума: {rowSum:F2}");
            }
            Console.WriteLine("Arithmetic average by columns:");
            for (int j = 0; j < size; j++)
            {
                double colSum = 0;
                for (int i = 0; i < size; i++)
                {
                    colSum += matrix[i, j];
                }
                double colAvg = colSum / size;
                Console.WriteLine($"Column {j}: Arithmetic avarage  = {colAvg:F2}");
            }
        }
    }
}

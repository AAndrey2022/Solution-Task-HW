// - Задайте двумерный массив. 
// - Напишите программу, которая упорядочит 
//   по убыванию элементы каждой строки двумерного массива.
//     Например, задан массив:
//     1 4 7 2
//     5 9 2 3
//     8 4 2 4
//     В итоге получается вот такой массив:
//     7 4 2 1
//     9 5 3 2
//     8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}, ");
        }
        Console.WriteLine("|");
    }

}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 0, 100);

PrintMatrix(createMatrixRndInt);
int[,] descendingElemMatrix = DescendingElemMatrix(createMatrixRndInt);

int[,] DescendingElemMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, max])
                    max = k;
            }
            int temp1 = matrix[i, j];
            matrix[i, j] = matrix[i, max];
            matrix[i, max] = temp1;
        }
    }
    Console.WriteLine();
    Console.Write("|");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}  ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
    return matrix;
}



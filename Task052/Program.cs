// - Задайте двумерный массив из целых чисел. 
// - Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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



double[] SumColumnsMatrix(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    // int res = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
        }
        arr[j] = result;
        Console.Write($" {Math.Round(arr[j]/matrix.GetLength(0), 1, MidpointRounding.ToZero), 4} ");

        // return 
        // res = result;
        // ($" -> {Math.Round(maxNumArray - minNumArray, 1, MidpointRounding.ToZero)}");

    }
    return arr;



}

// double[] meanSumcColumns = MeanSumcColumns(Array);
// double MeanSumcColumns(int[] arr)
// {
//     double res =0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//     Console.Write($"({arr[i]}) ");
//        res = arr[i] / arr.Length;
//     }
//      return res;
// }

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, -100, 100);


PrintMatrix(createMatrixRndInt);
double[] sumColumnsMatrix = SumColumnsMatrix(createMatrixRndInt);
// Console.WriteLine($"Среднее арифметическое каждого столбца:{sumColumnsMatrix}");

// double meanSumcColumns = MeanSumcColumns(Array);
// int sumColumnsMatrix= SumColumnsMatrix(rows);

// int MeanSumcColumn(object res)
// {
//     throw new NotImplementedException();
//     {
//     double res =0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         // Console.Write($"({arr[i]}) ");
//        res = arr[i] / arr.Length;
//     }
//      return res;
// }
// }


// Console.WriteLine(SumColumnsMatrix);

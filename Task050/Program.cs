//  Напишите программу, которая:
//  - на вход принимает позиции элемента в двумерном массиве, 
//  - и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите количество строк элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов элементов массива: ");
int num1 = Convert.ToInt32(Console.ReadLine());


int[,] CreateArrRndInt(int rows, int columns, int min, int max)
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

bool DefinitionValueMatrix(int[,] matrix, int num, int num1)
{
    bool res = false;
    bool res1 = true;

    if (num == matrix.GetLength(0) & num1 == matrix.GetLength(1))
        return res1;
    else return res;
}

int[,] createArrRndInt = CreateArrRndInt(3, 4, -100, 100);

PrintMatrix(createArrRndInt);

bool definitionValueMatrix = DefinitionValueMatrix(createArrRndInt, num, num1);
Console.Write(definitionValueMatrix);
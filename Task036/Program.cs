// - Задайте одномерный массив, заполненный случайными числами. 
// - Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] arr = CreateArrRndInt(4);
PrintArray(arr);
int summElementOddPositionArray = SummElementOddPositionArray(arr);
Console.Write($" -> {summElementOddPositionArray}");

int[] CreateArrRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-20, 10);
    }
    return array;
}

int SummElementOddPositionArray(int[] arr)
{
    int summOddPosition = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        summOddPosition = summOddPosition + arr[i];
    }
    return summOddPosition;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
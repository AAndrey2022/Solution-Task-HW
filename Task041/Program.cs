// - Пользователь вводит с клавиатуры M чисел. 
// - Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayUser(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
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

int ShowCountPositiveNumberArray(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            res = res + 1;
        }
    }
    return res;
}

int[] createArrayUser = CreateArrayUser(num);
int showCountPositiveNumberArray = ShowCountPositiveNumberArray(createArrayUser);

PrintArray(createArrayUser);
Console.Write($" -> {showCountPositiveNumberArray}");
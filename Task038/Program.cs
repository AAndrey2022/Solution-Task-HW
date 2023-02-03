// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrRndDouble(int size, int max, int min)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1, MidpointRounding.ToZero);
    }
    return array;
}

double DiferntMaxMinNumArray(double[] arr)
{
    double resMax = arr[0];
    double resMin = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (resMax < arr[i])
            
            resMax = arr[i];
         else
         if (resMin>arr[i])
            resMin=arr[i];
           
    }
    return resMax - resMin;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write("]");
}
double[] arr = CreateArrRndDouble(5, 1, 10);
PrintArray(arr);
double diferntMaxMinNumArray = DiferntMaxMinNumArray(arr);
Console.Write($" -> {Math.Round(diferntMaxMinNumArray, 1, MidpointRounding.ToZero)}");

    
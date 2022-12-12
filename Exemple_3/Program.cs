/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

//Получение максимального числа массива
int arrayMax(int[] array)
{
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else;
    }
    return max;
}

//Получение минимального числа массива
int arrayMin(int[] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else;
    }
    return min;
}

int []array = new int[8];

Random rnd = new Random();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100,999);
    Console.Write($"{array[i]} ");
}

int result = arrayMax(array) - arrayMin(array);

Console.WriteLine();

Console.WriteLine($"Разница между минимальным и максимальным значением равна {result}");

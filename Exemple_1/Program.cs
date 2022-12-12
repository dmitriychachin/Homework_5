/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int []array = new int[8];

Random rnd = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100,999);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
    else;
}

Console.WriteLine($"Количество четных чисел равно {count}");
/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

int []array = new int[8];

Random rnd = new Random();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100,999);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

for (int j = 1; j < array.Length; j += 2)
{
    sum = sum + array[j];
}

Console.WriteLine($"Сумма равна {sum}");
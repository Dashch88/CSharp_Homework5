// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = new int[4];
int sumOfOddPos = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
    if (i % 2 != 0) sumOfOddPos += array[i];
}
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве равна: {sumOfOddPos}");
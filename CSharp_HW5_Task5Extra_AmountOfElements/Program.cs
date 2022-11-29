// Задача 4: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] array = new int[12];
int countOfAmount = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write($"{array[i]} ");
    if (array[i] > 9 && array[i] < 100) countOfAmount++;
}
Console.WriteLine();

Console.WriteLine($"Количество элементов массива, которые входят в диапазон [10, 99] равно: {countOfAmount}");
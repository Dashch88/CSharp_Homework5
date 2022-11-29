// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] array = new int[5];
int minNum = 99;
int maxNum = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
    if (array[i] > maxNum) maxNum = array[i];
    if (array[i] < minNum) minNum = array[i];
}
Console.WriteLine();

int diffMaxMin = maxNum - minNum;

Console.WriteLine($"Максимальный элемент массива: {maxNum}");
Console.WriteLine($"Минимальный элемент массива: {minNum}");
Console.WriteLine($"Разница между max и min элементами: {diffMaxMin}");
// Задача 3: Задайте массив из 8 случайных чисел. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// один из вариантов. Самый простой -- это определение наличия хотя бы одного совпадающего элемента в массиве.
// делается в том же цикле, что и заполнение массива. Добавил второй для того, чтобы указать повторяющиеся элементы.

Console.Clear();

Console.WriteLine("Введите число, которое необходимо найти в массиве: ");
int desiredNum = int.Parse(Console.ReadLine());
bool desCount = false;

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write($"{array[i]} ");
    if (desiredNum == array[i]) desCount = true;
}
Console.WriteLine();

if (desCount == true)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (desiredNum == array[i]) Console.WriteLine($"Искомое число находится в массиве на {i}-й позиции.");
    }
} 
else Console.WriteLine("Искомое число отсутствует в массиве.");




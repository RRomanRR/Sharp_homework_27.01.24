
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй - предпоследним и т.д.)

// Так получилось, что я в одном решении выполнил обе задачи.

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Вы ввели ({n}) элементов массива, ваш массив: ");
int[] array = new int[n];
int i = 0;
while (i < n)
{
    array[i] = i + 100;
    Console.Write($"[{array[i]}] ");
    i++;
}
for (int j = 0; j < array.Length / 2; j++)
{
    int temp = array[j];
    array[j] = array[array.Length - 1 - j];
    array[array.Length - 1 - j] = temp;
}
Console.WriteLine();
Console.Write($"ВНИМАНИЕ! А теперь разворот массива из ({n}) элементов: ");
foreach (int e in array)
{
    Console.Write($"[{e}] ");
}
int result = 0;
foreach (int a in array)

    if (a % 2 == 0)

        result++;
Console.WriteLine();
Console.Write($"количество чётных чисел в массиве: {result} ");
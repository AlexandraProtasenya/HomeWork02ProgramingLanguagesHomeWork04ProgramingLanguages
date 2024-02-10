// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int GetCountOfEvenNubers(int[] array)
{
    int sum = 0;
    int firstDigit = 0;
    int secondDigit = 0;
    int thirdDigit = 0;
    int count = 0;
    foreach (int e in array)
    {
        firstDigit = e / 100;
        secondDigit = e % 100 / 10;
        thirdDigit = e % 10;
        sum = firstDigit + secondDigit + thirdDigit;
        if (sum % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine();
int even = GetCountOfEvenNubers(res);
Console.Write($"Результат: {even}");
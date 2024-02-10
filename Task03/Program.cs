// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int[] TurnArrayAround (int[] array)
{
    int j = array.Length - 1;
    int N = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        N = array[i];
        array[i] = array[j];
        array[j] = N;
        j--;
    }
    return array;
}


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", arr)} ]");
Console.WriteLine();
// int[] res = TurnArrayAround(arr);
Console.WriteLine($"Результат: {string.Join("; ", TurnArrayAround(arr))}");


// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.

int number = 0;
int sum = 0;

int GetSumOfDigits(int N)
{
    int i = 1;
    int sum = 0;
    int digit = 0;
    while (i < N)
    {
        i = i * 10;
    }
    for (int j = i / 10; j >= 1; j = j / 10)
    {
        digit = N / j;
        digit = digit % 10;
        sum = sum + digit;
    }
    return sum;
}

while (true)
{
    Console.Write("Введите целое число ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    if (int.TryParse(input, out number)) // == true, срока состоит из цифр
    {
        sum = GetSumOfDigits(number);
        if (sum % 2 == 0)
        {
            break;
        }
    }
}
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// получение числа
int GetNumber(string messeg)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messeg);
        if (int.TryParse(Console.ReadLine(), out result) && result>0) break;
        else Console.WriteLine("Введино не число или число меньше 1");
    }
    return result;
}

void GetValues (int num)
{
    Console.WriteLine($"{num} ");
    num--;
    if (num>0)
    {
        GetValues(num);
    }
}

GetValues(GetNumber("введите N: "));

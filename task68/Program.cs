/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string messeg)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(messeg);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0) break;
        else Console.WriteLine("Введино не число или число меньше 1");
    }
    return result;
}

int AcermanFunction(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = AcermanFunction(n, m - 1);
        n--;
    }
    return m + 1;
}

int m = GetNumber("Введите m: "),
    n = GetNumber("Введите n: ");

Console.WriteLine(AcermanFunction(m, n));
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int exponentiate(int a, int b)
{
    int mem = 1;
    for (int i = 0; i < b; i++)
    {
        mem = mem*a;
    }
    return mem;
}

int GetNumber(string masseg)
{
    int result = 0;
    bool isCorect= false;

    while(!isCorect)
    {       
        Console.Write(masseg);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorect = true;
        }
        else
        {
            Console.WriteLine("Введенно не число или 0");
        }
    }
    return result;
}

int a = GetNumber("введите возводимое число ");
int b = GetNumber("введите степень числа ");
Console.WriteLine(exponentiate(a,b)+ " <--" +a+" в степни "+b);
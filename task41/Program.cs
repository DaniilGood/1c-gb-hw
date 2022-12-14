/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3  */

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
            Console.WriteLine("Введенно не число. Введите число");
        }
    }
    return result;
}
//количество чисел меньше нуля
int LessZero(int[] array)
{
    int resalt =0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if(array[i]<0) resalt++;
    }
    return resalt;
}

int size = Math.Abs(GetNumber("Введите количество чисел: "));
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = GetNumber("Введите число: ");
}

Console.Write(LessZero(array));
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int NumberLength(int num)
{
    if(num<0) num = -num;
    int length = 1;
    int i = 10;
    while (i < num)
    {
        i = i*10;
        length++;
    }


    return length;
}

int[] DigitOfNumber(int num, int numLength)
{
    if(num<0) num = -num;
    int[] array = new int[numLength];
    for (int i = 0; i < numLength; i++)
    {
        array[i]=num%10;
        num= num/10;
    }

    return array; 
}

int num = GetNumber("Введите число: ");
int result = 0;
for (int i = 0; i < NumberLength(num); i++)
{
    result =result+ DigitOfNumber(num,NumberLength(num))[i];
}

Console.Write(result);

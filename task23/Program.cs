//поучение числа
int GetNumber(string masseg)
{
    int result = 0;
    bool isCorect= false;

    while(!isCorect)
    {       
        Console.Write(masseg);
        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
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
//получение знака числа
int NumberSign(int num)
{
    short sign;
    if(num<0)
        sign=-1;
    else
        sign=1;
    return sign;
}

int num = GetNumber("Введите число :");
int index =1, result;

while(index<= Math.Abs(num))
{
    result = index*index*index*NumberSign(num);
    Console.Write(result+" ");
    index++;
}

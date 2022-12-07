int GetNumber(string masseg)
{
    int result = 0;
    bool isCorect= false;

    while(!isCorect)
    {       
        Console.Write(masseg);
        if(int.TryParse(Console.ReadLine(), out result) && result >9999 && result <100000)
        {
            isCorect = true;
        }
        else
        {
            Console.WriteLine("Введенно не число или число вне диапазона");
        }
    }
    return result;
}

int a = GetNumber("Введите пятизначное число: ");
if ((a% 100000)/10000==a%10 && (a%10000)/1000==(a%100)/10)
{
   Console.WriteLine(a+" -->да"); 
}
else
{
    Console.WriteLine(a+" -->нет"); 
}
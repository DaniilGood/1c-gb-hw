//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int a = num% 2;

if(a == 0)
{
    Console.WriteLine(num+ "-> чет");
}
else
{
    Console.WriteLine(num+ "-> нечет");
}
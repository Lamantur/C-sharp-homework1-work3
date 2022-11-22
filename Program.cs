//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string input_Value = Console.ReadLine();
int Value = Convert.ToInt32(input_Value);

if (Value % 2 == 0)
{
    System.Console.WriteLine("ДА");
}
else
{
    System.Console.WriteLine("НЕТ");
}
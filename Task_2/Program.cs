// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Введите число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
int len = str.Length;
int sum = 0;
int index = 0;
for (index = 0; index < len; index++)
{
    var a = number % 10;
    number = number / 10;
    sum = sum + a;
}
System.Console.WriteLine($"Сумма цифр числа {str} равна {sum}");

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
int promt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberA = promt("Введите число: ");
int numberB = promt("Введите степень: ");

int a = numberA;

while (numberB > 1)
{
    numberA = numberA * a;
    numberB--;
}

System.Console.WriteLine($"{numberA}");


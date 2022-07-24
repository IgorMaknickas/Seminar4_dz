//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int getSumma(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(getSumma(A));
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число, и я выдам сумму цифр в числе");
int number = int.Parse(Console.ReadLine());

int FindSum (int num)
{
    int result = 0;
    while(num > 0)
    {
        int digit = num %10;
        result = result + digit;
        num = num /10;
    }
    return result;
}

int sum = FindSum(number);
Console.WriteLine($"сумма цифр в числе {number} равна {sum}");
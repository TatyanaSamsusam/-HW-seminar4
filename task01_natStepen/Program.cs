/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите два числа (A и B), и я возведу число A в натуральную степень B");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int FindPower(int a, int b)
{
    int powres = 1;
    for (int i = 0  ; i < b; i++)
    {
        powres = powres * a;
    }
    return powres;
}

int result = FindPower(numberA, numberB);
Console.WriteLine($"{numberA} в {numberB} степени равно {result}");
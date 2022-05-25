/* Задача 29: Напишите программу, которая задаёт массив целых чисел и выводит их на экран. Размер массива определяется пользователем.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("введите число, и я выведу на экран массив целых чисел. Размер массива будет равен введенному числу");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 101);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[number];
FillArray(array);
PrintArray(array);
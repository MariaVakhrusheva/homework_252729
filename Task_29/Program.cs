/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void ShowCubes(int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i < number; i++)
    {
        Console.Write($"{i * i * i}, ");
    }
    Console.Write(number * number * number);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число: ");
ShowCubes(number);

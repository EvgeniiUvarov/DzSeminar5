//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


using System;
using static System.Console;
Clear();

Write("Введи числа: ");
int[] array = GetArrayString(ReadLine());

WriteLine($"Чисел больше нуля {String.Join(", ", (MultiPair(array)))}");

int[] GetArrayString(string arrayStr)
{
    string[] arS = arrayStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for (int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);
    }
    return result;
} 

int MultiPair (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result+=1;
        }
    }
    return result;
}
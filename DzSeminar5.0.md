//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();


int[]array = GetRandomAray(10,100,1000);
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Количество положительных чисел = {SummChetNumbers(array)}");


int[] GetRandomAray(int Length, int min, int max)
{
    int[] array = new int [Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

int SummChetNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
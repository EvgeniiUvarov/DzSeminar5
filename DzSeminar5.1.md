//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

int[]array = GetRandomArray(4,-30,100);
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Сумма чисел = {SumNegArray(array)}");


int[] GetRandomArray(int Length, int min, int max)
{
   int[] result = new int[Length];
   for (int i = 0; i < Length; i++)
   {
    result[i] = new Random().Next(min,max+1);
   }
   return result;
}

int SumNegArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       sum += array[i];
    }
    return sum;
}
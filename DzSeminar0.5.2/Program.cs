//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();



double[] GetRandomAray = new double[10];
  for (int i = 0; i < GetRandomAray.Length; i++ )
  {
    GetRandomAray[i] = new Random().Next(1, 100);
  }

WriteLine($"{String.Join(",",GetRandomAray)}");

double maxNumber = GetRandomAray[0];
double minNumber = GetRandomAray[0];

  for (int i = 1; i < GetRandomAray.Length; i++)
  {
    if (maxNumber < GetRandomAray[i])
    {
      maxNumber = GetRandomAray[i];
    }
        if (minNumber > GetRandomAray[i])
    {
      minNumber = GetRandomAray[i];
    }
  }

  double sum = maxNumber - minNumber;

  WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами равна: {sum}");
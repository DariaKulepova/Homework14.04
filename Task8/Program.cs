using System;

int N;

Console.WriteLine("Input number");
N=int.Parse(Console.ReadLine());

int count=2;

while (count<=N)
 {
      Console.Write($"{count} ");
      count=count+2;
  }
if (N<=1)
Console.WriteLine("Таких чисел нет");
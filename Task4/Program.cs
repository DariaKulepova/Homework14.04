using System;

int numberA;
int numberB;
int numberC;

Console.WriteLine("Input first number");
numberA=int.Parse(Console.ReadLine());

Console.WriteLine("Input second number");
numberB=int.Parse(Console.ReadLine());

Console.WriteLine("Input third number");
numberC=int.Parse(Console.ReadLine());

int max=numberA;

if (numberB>max) max=numberB;
if (numberC>max) max=numberC;
Console.Write("max= ");
Console.Write(max);
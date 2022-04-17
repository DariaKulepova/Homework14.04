using System;

int numberA;
int numberB;

Console.WriteLine("Input first number");
numberA=int.Parse(Console.ReadLine());

Console.WriteLine("Input second number");
numberB=int.Parse(Console.ReadLine());

int max=numberA; 
int min=numberB;

if (numberA>numberB)
{
Console.WriteLine($"max={numberA} min={numberB}");
}
else
{
Console.WriteLine($"max={numberB} min={numberA}"); 
}
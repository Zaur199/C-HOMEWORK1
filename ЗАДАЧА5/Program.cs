﻿// Показать четные числа от 1 до N
Console.WriteLine("Введите длину: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
    if(i % 2 == 0)
    {
        Console.WriteLine("Чётные числа: " + i);    
    }

Console.WriteLine();
// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int number = a;

if(a % 2 == 0)
    {
        Console.WriteLine("Число чётное");
        
    }
else
    Console.WriteLine("Число нечётное");
Console.WriteLine();
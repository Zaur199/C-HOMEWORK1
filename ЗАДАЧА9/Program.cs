// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if(a%b==0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}

if(a%b!=0) 
{
    Console.WriteLine($"Число {a}  не кратно числу {b}");
    Console.WriteLine("остаток: " + a%b);
}
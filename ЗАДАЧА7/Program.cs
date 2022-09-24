// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите любое число из отрезка [10, 99]");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую цифру выше введённого числа");
 int m = int.Parse(Console.ReadLine());
 int max = m;
 Console.WriteLine("Введите вторую цифру выше введённого числа");
int n = int.Parse(Console.ReadLine());
int min = n;

if(m < n)
    {
        Console.WriteLine("Максимальная цифра: " + n);
    }

else
    Console.WriteLine("Максимальная цифра " + m);

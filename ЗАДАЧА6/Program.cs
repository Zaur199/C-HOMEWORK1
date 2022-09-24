// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
num = (num/10) % 10;
Console.WriteLine(num);
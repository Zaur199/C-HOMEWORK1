//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine());
int result = (a/100)%10;
Console.Write(result);
Console.Write(a%10);
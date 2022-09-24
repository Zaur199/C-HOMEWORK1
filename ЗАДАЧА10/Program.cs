// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
int index = 0;
 
 Console.WriteLine(str[2]);
Console.Clear();
Console.Write("Введите пожалуйста трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
int second = a / 10;
int first = a / 100;
int result = second - first * 10;
Console.WriteLine($"{result}");

Console.Clear();
Console.Write("Введите пожалуйста день недели в виде цифры: ");
int n = int.Parse(Console.ReadLine());
if (n == 6 || n == 7) 
    Console.WriteLine("Этот день выходной");
else if (n < 1 || n > 7)
    Console.WriteLine("Введите пожалуйста число от 1 до 7");
else if (1 <= n && n <=5)
    Console.WriteLine("Это рабочий день");
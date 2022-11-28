Console.Clear();
Console.Write("Введите пожалуйста число: ");
int n = int.Parse(Console.ReadLine());
if (n < 100)
    Console.WriteLine("третьей цифры нет");
else {
while ( n >= 1000)
    n = n / 10;
    
}
Console.WriteLine (n % 10);

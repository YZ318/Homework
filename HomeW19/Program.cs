Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int a = number / 10000;
int b = (number / 1000) % 10;
int c = (number / 100) % 10;
int d = (number / 10) % 10;
int e = number % 10;

if (a == e && b == d)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}


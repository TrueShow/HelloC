Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Число: {number / 100}{number % 10}");

Console.WriteLine("Введите число от 10 до 99");
int number = int.Parse(Console.ReadLine());
int max = 0;
if (number < 10 || number > 99) {
    Console.WriteLine("Неверное число, введите от 10 до 99");
}
else {
    max = number / 10;
    if (number % 10 > max) {
        max = number % 10;
    }
}
Console.WriteLine("Максимальное число: " + max);

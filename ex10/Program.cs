Console.WriteLine("Введите число, максимальное 999, минимальное 0");
int number = int.Parse(Console.ReadLine());

if (number / 100 > 0) {
    Console.WriteLine($"Третье число от заданного = {number %10}");
}
else {
    Console.WriteLine($"Нет третьего число в заданном числе {number}");
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кратность");
int secondNumber = int.Parse(Console.ReadLine());

if (number % secondNumber == 0) {
    Console.WriteLine($"Заданное число {number} кратное {secondNumber}");
}
else {
    Console.WriteLine($"Остаток от заданного числа {number} = {number % secondNumber}");
}
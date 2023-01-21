Console.WriteLine("Введите первое число:");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secontNum = int.Parse(Console.ReadLine());

if (secontNum * secontNum == firstNum) {
    Console.WriteLine("Первое число является квадратом второго");
}
else {
    Console.WriteLine("Первое число не является квадратом второго");
}
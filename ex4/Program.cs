Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number < 1) {
    Console.WriteLine("число должно быть положительным");
}
else {
    for (int i = 1; i < number; i++){
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }
}
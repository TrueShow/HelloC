Console.WriteLine("Введите номер дня недели: ");
int dayOfweek = int.Parse(Console.ReadLine());

if (dayOfweek > 7 || dayOfweek < 1) {
    Console.WriteLine("Неверный номер дня недели");
}
else {
    switch (dayOfweek) {
        case 1:
            Console.WriteLine("понедельник");
            break;
        case 2:
            Console.WriteLine("вторник");
            break;
        case 3:
            Console.WriteLine("среда");
            break;
        case 4:
            Console.WriteLine("четверг");
            break;
        case 5:
            Console.WriteLine("пятница");
            break;
        case 6:
            Console.WriteLine("суббота");
            break;
        case 7:
            Console.WriteLine("воскресенье");
            break;
    }
}

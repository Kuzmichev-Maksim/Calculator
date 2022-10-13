// See https://aka.ms/new-console-template for more information{
while (true)
{
    Console.WriteLine(" ");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Найти квадратный корень");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    Console.WriteLine("Введите номер операции:");
    int o = Convert.ToInt32(Console.ReadLine());
    if (o == 9 || o < 1 || o > 9 )
    {
        Console.WriteLine("Вы вышли из программы или была введена не существующая операция");
    }
    else 
    Console.Write("Введите первое число: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double b;
    switch (o)
    {
        case 1:
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + b);
            break;
        case 2:
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a - b);
            break;
        case 3:
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a * b);
            break;
        case 4:
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Ошибка. Невозможно поделить на 0 ");
                break;
            }
            Console.WriteLine(a / b);
            break;
        case 5:
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            double r = 1;
                for (int i = 1; i <= b; i++)
                {
                    r *= a;
                }
                Console.WriteLine(r);
                break;
        case 6:
            if (a < 0)
            {
                Console.WriteLine("Ошибка. Невозможно найти корень отрицательного числа");
                break;
            }
            Console.WriteLine(Math.Sqrt(a));
            break;
        case 7:
            Console.WriteLine(a / 100);
            break;
        case 8:
            if (a == 0)
            {
                Console.WriteLine("1");
                break;
            }
            else if (a < 0)
            {
                Console.WriteLine("Ошибка. Невозможно найти факториал отрицательного числа");
                break;
            }
            double r = 1;
            for (int i = 1; i <= a; i++)
            {
                r *= i;
            }
            Console.WriteLine(r);
            break;
    }
}
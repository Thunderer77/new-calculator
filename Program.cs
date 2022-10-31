using System.Linq.Expressions;
Console.WriteLine("Введите операцию из списка:");
Console.WriteLine("1. Сложить 2 числа\n2. Вычесть первое из второго\n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести в степень N первое число\n6. Найти квадратный корень из числа\n7. Найти 1% от числа\n8. Найти факториал\n9. Выйти из программы");
int operation = Convert.ToInt32(Console.ReadLine());
while (operation != 9)
{
    if (operation == 1)
    {
        Console.WriteLine("Введите a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма :");
        int c = a + b;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 2)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Разность :");
        int c = a - b;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 3)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат :");
        int c = a * b;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 4)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат :");
        int c = a / b;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 5)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат :");
        int c = Convert.ToInt32(Math.Pow(a, N));
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 6)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат :");
        int c = Convert.ToInt32(Math.Sqrt(a));
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 7)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 100;
       Console.WriteLine("Результат :");
        int c = (a / b) ;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    if (operation == 8)
    {
        Console.WriteLine("Введите а");
        int a = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        for (int i = 1; i <= a; i++)
            f *= i;
        Console.WriteLine("Результат :");
        int c = f ;
        Console.WriteLine(c);
        Console.WriteLine("Введите ещё одну операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Некоректно введено число.\nПовторите попытку.");
        Console.WriteLine("Введите операцию: ");
        operation = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Вы прошли калькулятор");

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задание");
        Console.WriteLine("1 задание - вычислить факториал числа");
        Console.WriteLine("2 задание - вычислить последовательность чисел Фибоначчи");
        Console.WriteLine("3 задание - вычислить значение функции");
        Console.WriteLine("4 задание - вычислить сумму ряда Тейлора");

        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Zadanie1();
        }
        if (n == 2)
        {
            Zadanie2();
        }
        if (n == 3)
        {
            Zadanie3();
        }
        if (n == 4)
        {
            Zadanie4();
        }
        Console.ReadKey();
    }

    static void Zadanie1()
    {
        Console.WriteLine("Введите число 0..10: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("Ошибка: введите целое число");
            return;
        }
        if (n < 0)
        {
            Console.WriteLine("Ошибка: число не может быть меньше 0");
            return;
        }
        if (n > 10)
        {
            Console.WriteLine("Ошибка: введи нужное число");
            return;
        }

        long rezult = 1;
        for (int i = 2; i <= n; i++)
        {
            rezult *= i;
        }
        Console.WriteLine("Факториал числа " + n + " = " + rezult);
    }

    static void Zadanie2()
    {
        Console.WriteLine("Введите число 0..10: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) == false)
        {
            Console.WriteLine("Ошибка: введите целое число");
            return;
        }
        if (n <= 0)
        {
            Console.WriteLine("Ошибка: число не может быть меньше или равно 0");
            return;
        }

        int a = 0;
        int b = 1;
        
        for (int i = 0;  i < n; i++)
        {
            Console.Write(a);
            if (i < n -1)
            {
                Console.Write(", ");
            }
            int c = a + b;
            a=b; b=c;
        }
    }

    static void Zadanie3()
    {
        Console.Write("Введите x: ");
        double x;
        if (double.TryParse(Console.ReadLine(), out x) == false)
        {
            Console.WriteLine("Ошибка: введите число");
            return;
        }

        if (x <= 0)
        {
            Console.WriteLine("Ошибка: x должен быть больше 0");
            return;
        }

        double inside = Math.Log(4.0 / x) - 1.0 / x - Math.Exp(Math.Sin(x));

        if (inside < 0)
        {
            Console.WriteLine("Ошибка: под корнем получилось отрицательное число");
            return;
        }

        double A = Math.Sqrt(inside);

        Console.WriteLine("A = " + A);
    }

    static void Zadanie4()
    {
        Console.Write("Введите x: ");

        double x;

        if (double.TryParse(Console.ReadLine(), out x) == false)
        {
            Console.WriteLine("Ошибка: введите число");
            return;
        }

        if (x <= -1 || x > 1)
        {
            Console.WriteLine("Ошибка: x должен быть больше -1 и меньше или равен 1");
            return;
        }

        double eps = 0.000001;
        double sum = 0;
        double term; // текущий элемент ряда
        int n = 0; // нужен что бы понять какой сейчас элемент ряда

        do
        {
            term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);

            sum = sum + term;

            n++;
        }
        while (Math.Abs(term) > eps);

        Console.WriteLine("Сумма ряда = " + sum);
        Console.WriteLine("Точное значение arctg(x) = " + Math.Atan(x));
        Console.WriteLine("Количество членов ряда = " + n);
    }
}


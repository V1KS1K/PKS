using System;

class Calculator
{
    static void Main()
    {
        double current = 0;
        double memory = 0;

        while (true)
        {
            Console.WriteLine($"\nТекущее значение: {current} | Память: {memory}");
            Console.Write("Введите операцию (+, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR, C, exit): ");
            string op = Console.ReadLine();

            if (op.ToLower() == "exit") break;

            try
            {
                if (op == "+" || op == "-" || op == "*" || op == "/" || op == "%")
                {
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    switch (op)
                    {
                        case "+": current = a + b; break;
                        case "-": current = a - b; break;
                        case "*": current = a * b; break;
                        case "/": 
                            if (b == 0) { Console.WriteLine("Ошибка: Деление на ноль!"); continue; }
                            current = a / b; break;
                        case "%": 
                            if (b == 0) { Console.WriteLine("Ошибка: Деление на ноль!"); continue; }
                            current = a % b; break;
                    }

                    Console.WriteLine($"Результат: {current}");
                }
                else if (op == "1/x")
                {
                    Console.Write("Введите число: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    if (n == 0) { Console.WriteLine("Ошибка: Деление на ноль!"); continue; }
                    current = 1 / n;
                    Console.WriteLine($"Результат: {current}");
                }
                else if (op == "x^2")
                {
                    Console.Write("Введите число: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    current = n * n;
                    Console.WriteLine($"Результат: {current}");
                }
                else if (op == "sqrt")
                {
                    Console.Write("Введите число: ");
                    double n = Convert.ToDouble(Console.ReadLine());
                    if (n < 0) { Console.WriteLine("Ошибка: Нельзя извлечь корень из отрицательного числа!"); continue; }
                    current = Math.Sqrt(n);
                    Console.WriteLine($"Результат: {current}");
                }
                else if (op == "M+")
                {
                    memory += current;
                    Console.WriteLine($"Добавлено в память: {current}");
                }
                else if (op == "M-")
                {
                    memory -= current;
                    Console.WriteLine($"Вычтено из памяти: {current}");
                }
                else if (op == "MR")
                {
                    current = memory;
                    Console.WriteLine($"Восстановлено из памяти: {memory}");
                }
                else if (op == "C")
                {
                    current = 0;
                    Console.WriteLine("Калькулятор очищен");
                }
                else
                {
                    Console.WriteLine("Неизвестная операция!");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка: Неверный ввод числа!");
            }
        }

        Console.WriteLine("Калькулятор завершил работу.");
    }
}



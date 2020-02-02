//2. Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
//    Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку деления на ноль.
//Написать программу, которая будет выполнять арифметические действия указанные пользователем.
using System;

namespace Task2
{
    class Program
    {
        delegate double Operation(double a, double b);
        static void Main(string[] args)
        {
            Operation add = (a, b) => a + b;
            Operation sub = (a, b) => a - b;
            Operation mul = (a, b) => a * b;
            Operation div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();

            Console.WriteLine("Input first number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second number");
            int y = int.Parse(Console.ReadLine());


            while (true)
            {
                Console.WriteLine("Press +, -, *, / for continue or any other key for exit");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Console.WriteLine($"({x} + {y}) = {add.Invoke(x, y)}");
                        break;
                    case "-":
                        Console.WriteLine($"({x} - {y}) = {sub.Invoke(x, y)}");
                        break;
                    case "*":
                        Console.WriteLine($"({x} * {y}) = {mul.Invoke(x, y)}");
                        break;
                    case "/":
                        Console.WriteLine($"({x} / {y}) = {div.Invoke(x, y)}");
                        break;
                    default: return;
                }
            }

            
        }
    }
}

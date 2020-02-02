//1. Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
using System;

namespace Task1
{
    class Program
    {
        delegate double Operation(int a, int b, int c);
        static void Main(string[] args)
        {
            Operation operation = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3f;
            };
            Console.WriteLine("Input first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third number");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine($"AVG({x},{y},{z}) = {operation.Invoke(x, y, z)}");
        }
    }
}

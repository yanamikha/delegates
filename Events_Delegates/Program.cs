//3. Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов
//    сообщенных с делегатами в массиве.Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. 

using System;

namespace Events_Delegates
{
    class Program
    {
        delegate double  MessageHandler( DelegateArray [] delegateArrays  );
        delegate int DelegateArray(); 
        static int RandomInt()
        {
            Random random = new Random();
            var res = random.Next(100);
            Console.Write(res + " " );
            return res;
        }
        static void Main(string[] args)
        {

            DelegateArray[] delegateArray = new DelegateArray[10];

            for (int i = 0; i < delegateArray.Length; i++)
                delegateArray[i] += RandomInt;

            MessageHandler handler = delegate (DelegateArray[] delegateArrays)
            {
                double sum = 0;
                Console.WriteLine("Random numbers:");
                for (int i = 0; i < delegateArray.Length; i++)
                    sum += delegateArrays[i].Invoke();
                return sum /= delegateArray.Length;
            };
            Console.WriteLine("\r\nTheir sum is: " + handler(delegateArray));

        }
    }
}

using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Охаё!");
            Console.WriteLine("Давай x и я расчитаю y=sin(x) при x>0 или y=cos(x) в ином");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
                Console.WriteLine($"sin(x) = {Math.Sin(x)}");
            else Console.WriteLine($"cos(x) = {Math.Cos(x)}");

            Console.WriteLine("\nНажмите любую клавишу для выхода.");//чтобы приложение сразу не закрывалось
            Console.ReadKey();
        }
    }
}

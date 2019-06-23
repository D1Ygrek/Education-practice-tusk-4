using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 1.5;
            Console.WriteLine("Введите точность решения");
            double epsilon = DoubleCheck();
            do
            {
                double c = (a+b) / 2;
                if (F(a) * F(c) <= 0) b = c;
                else a = c;
            } while (b - a > epsilon);
            double x = (a + b) / 2;
            Console.WriteLine("Ваш ответ " + x);
            Console.ReadLine();
        }
        static double DoubleCheck()
        {
            double n;
            bool ok = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string s = Console.ReadLine();
            do
            {
                ok = double.TryParse(s, out n);
                if (ok == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ввод неправильный. Повторите.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    s = Console.ReadLine();
                }
            } while (!ok);
            Console.ForegroundColor = ConsoleColor.White;
            return (n);
        }
        static double F(double x)
        {
            return (x * x * x - 0.2 * x * x - 0.2 * x - 1.2);
        }
    }
}

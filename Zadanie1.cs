using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, perimeter;
            a = b = c = perimeter =  0;
            double area = 0;
            int angle = 0;

            Console.Write("Введите гипотенузу: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите угол (от 1 до 89): ");
            angle = Convert.ToInt32(Console.ReadLine());

            a = c * Math.Sin(angle*3.14/180);
            b = c * Math.Cos(angle*3.14/180);

            perimeter = a + b + c;

            area = (a * b) / 2;

            Console.Write("Первый катет: {0}, второй катет: {1}\n", a, b);
            Console.Write("Периметр: {0}, площадь: {1}\n", perimeter, area);


            Console.ReadKey();
        }
    }
}

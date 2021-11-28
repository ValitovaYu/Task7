using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z1=");
            double z1 = Convert.ToDouble(Console.ReadLine());

            if (x1 + y1 <= z1 || x1 + z1 <= y1 || y1 + z1 <= x1)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
                Console.WriteLine("Введите длины сторон второго треугольника");
                Console.Write("x2=");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y2=");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("z2=");
                double z2 = Convert.ToDouble(Console.ReadLine());

                if (x2 + y2 <= z2 || x2 + z2 <= y2 || y2 + z2 <= x2)
                {
                    Console.WriteLine("Такого треугольника не существует");
                }
                else
                {
                    double S1 = SqrTriangle(x1, y1, z1);
                    double S2 = SqrTriangle(x2, y2, z2);
                    if (S1 > S2)
                    {
                        Console.WriteLine("Площадь 1 треугольника больше");
                    }
                    else
                    {
                        if (S1 < S2)
                        {
                            Console.WriteLine("Площадь 2 треугольника больше");
                        }
                        else
                            Console.WriteLine("Площади равны");
                    }
                }
            }
            
            Console.ReadKey();


        }
        // создать метод для вычисления  площади  треугольника по длинам его сторон //
        static double SqrTriangle(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }


    }
}


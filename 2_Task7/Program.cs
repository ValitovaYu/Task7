using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());

            vCube(x); 
            
            Console.ReadKey();

        }
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.//
        static void vCube(double x)
        {
            double S = 6*(Math.Pow(x, 2));
            double V = Math.Pow(x,3);
            Console.WriteLine("Площадь поверхности куба S={0}", S);
            Console.WriteLine("Объем куба V={0}", V);
        }
    }
}

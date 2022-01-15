using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности= ");
            double r = Convert.ToDouble(Console.ReadLine());
            double L = Circle.Length(r);
            double S = Circle.GetSquare(r);
            Console.Write("Введите координату Х1= ");
            double x01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату У1= ");
            double y01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату Х0= ");
            double x00 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату У0= ");
            double y00 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности={0:f2}",L);
            Console.WriteLine("Площадь окружности={0:f2}", S);
            Console.WriteLine("Точка с координатами Х1,У1 принадлежит окружности с центром в Х0,У0 и заданным радиусом? {0:f2}", Circle.GetXY(r,x00,y00,x01,y01));
            Console.ReadKey();
        }
    }
    static class Circle
    {
        public static double Length(double R)
        {
            return Math.PI * 2 * R;
        }
        public static double GetSquare(double R)
        {
            return Math.Pow(Math.PI, 2) * R;
        }
        public static bool GetXY (double R, double x0, double y0, double x1, double y1)
        {
            double Rt = Math.Sqrt(Math.Pow((x1 - x0), 2)+ Math.Pow((y1 - y0), 2));
            if (Rt < R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

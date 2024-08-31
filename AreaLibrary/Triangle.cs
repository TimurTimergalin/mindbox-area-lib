using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : IHaveArea
    {
        // Стороны треугольника сразу хранятся в упорядоченном виде, чтобы не сортировать их при каждом
        // вызове проверки на прямоугольность
        private double minSide;
        private double middleSide;
        private double maxSide;

        public Triangle(double a, double b, double c)
        {
            // minSide = Math.Min(a, Math.Min(b, c));
            // maxSide = Math.Max(a, Math.Max(b, c));
            // middleSide = a + b + c - minSide - maxSide;
            // Код свреху, хоть и понятный, но страдает от ошибок округления (например, при a == b == c == 0.1, middleSide == 0.10000000000000003
            // Поэтому, чтобы не использовать суммы, придется все сравнивать вручную
            if (a < b)
            {
                if (a < c)
                {
                    minSide = a;
                    middleSide = Math.Min(b, c);
                    maxSide = Math.Max(b, c);
                }
                else
                {
                    middleSide = a;
                    minSide = Math.Min(b, c);
                    maxSide = Math.Max(b, c);
                }
            }
            else
            {
                if (b < c)
                {
                    minSide = b;
                    middleSide = Math.Min(a, c);
                    maxSide = Math.Max(a, c);
                }
                else
                {
                    middleSide = b;
                    minSide = Math.Min(a, c);
                    maxSide = Math.Max(a, c);
                }
            }
        }

        public double Area
        {
            get
            {
                double p = (minSide + middleSide + maxSide) / 2;  // Полупериметр
                double area2 = p * (p - minSide) * (p - middleSide) * (p - maxSide);  // Формула Герона без кв. корня
                return Math.Sqrt(area2);
            }
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="eqPrecision">Точность сравнения на равенство: два числа a и b будут считаться равными, если и только если |a - b| < eqPrecision. По умолчанию равен 1e-10</param>
        /// <returns></returns>
        public bool IsRight(double eqPrecision = 1e-10)
        {
            return Math.Abs(minSide * minSide + middleSide * middleSide - maxSide * maxSide) < eqPrecision;
        }
    }
}

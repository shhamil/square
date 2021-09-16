using System;

namespace square
{
    public class Triangle
    {
        public int a;
        public int b;
        public int c;


        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает площадь треугольника, если треугольника с заданными сторонами не существует, вернет 0</returns>
        public double square()
        {
            if ((a + b) <= c || (a + c) <= b || (b + c) <= a)
            {
                return 0;
            }
            else
            {
                double p = (a + b + c) / 2;
                double sq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return sq;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace square
{
    public class Circle
    {
        public int radius;

        public Circle(int r)
        {
            radius = r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает площадь круга, если круга с заданным радиусом не существует, вернет 0</returns>
        public double square()
        {
            if (radius <= 0)
            {
                return 0;
            }
            else
            {
                double sq = Math.PI * (radius * radius);
                return sq;
            }
        }
    }
}

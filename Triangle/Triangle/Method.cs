using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Method
    {
        /// <summary>
        /// Метод проверяет тип тругольника и возвращает идентификатор типа и его название
        /// </summary>
        /// <param name="a">первая сторона треугольника</param>
        /// <param name="b">вторая сторона треугольника</param>
        /// <param name="c">третья сторона треугольника</param>
        /// <returns>
        /// не существует;
        /// равносторонний;
        /// равнобедренный;
        /// разносторонний;
        /// </returns>
        public static string CheckTriangle(int a, int b, int c)
        {
            if ((c >= a + b) || (a >= b + c) || (b >= a + c))
            {
                return "не существует";
            }
            else if (a == b && b == c)
            {
                return "равносторонний";
            }
            else if (a == b || b == c || a == c)
            {
                return "равнобедренный";
            }
            else
            {
                return "разносторонний";
            }
        }
    }
}

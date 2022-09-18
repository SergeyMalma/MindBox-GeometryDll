using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{        /// <summary>
         /// Треугольник
         /// </summary>
    public class Triangle : Figure
    {
        /// <param name="_side1">Первая сторона треугольника</param>
        /// <param name="_side2">Вторая сторона треугольника</param>
        /// <param name="_side3">Третья сторона треугольника</param>
        public double _side1,_side2,_side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Одна из сторон меьньше или равна 0");
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            
        }
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        /// <param name="square">Площадь фигуры</param>
        public double TriangleArea()
        {
            var perimeter = (_side1 + _side2 + _side3) / 2;
            square = (Math.Sqrt(perimeter * (perimeter - _side1) * (perimeter - _side2) * (perimeter - _side3)));
            return square;
        }
        /// <summary>
        /// Проверка, является ли треугольник прямоугольником 
        /// </summary>
        public bool GetRightTriangle()
        {
            
            List<double> sides = new List<double>() { _side1,_side2,_side3 };
            sides.Sort();
            double s1=Math.Pow(sides[2], 2d);
            double s2 = Math.Pow(sides[0], 2d) + Math.Pow(sides[1], 2d);
            if (s1 == s2)
                return true;
            else
                return false;
        }

    }
}

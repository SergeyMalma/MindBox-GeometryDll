using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{        /// <summary>
         /// Круг
         /// </summary>
    public class Circle : Figure
    {
        /// <param name="_сircleRadius">Радиус круга</param>
        public double _сircleRadius;
        public Circle(double сircleRadius)
        {
            if (сircleRadius<=0)
                throw new ArgumentException("Радиус меньше или равен 0");
            _сircleRadius = сircleRadius;
        }
        /// <summary>
        /// Вычислить площать круга
        /// </summary>
        /// <param name="square">Площадь фигуры</param>
        public double CircleArea()
        {
            square = (Math.Pow(_сircleRadius, 2) * Math.PI);
            return square;
        }
    }
}

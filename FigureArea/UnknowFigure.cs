using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FigureArea
{
    public class UnknowFigure : Figure
    {
        /// <summary>
        /// Многоугольник
        /// </summary>
        /// /// <param name="vector">Список, содержащий вершины многоугольника</param>
        List<double> vector=new List<double>();
        public UnknowFigure(List<double> points)
        {
            if(vector.Count()%2 !=0)
                throw new ArgumentException("Введены неверные координаты многоугольника");
            foreach (var point in points)
            {
                vector.Add(point);
            }
        }
        public double UnknowFigureArea()
        {
            int count=vector.Count();
            int y = 1;
            int x = 0;
            double sum1=0;
            double sum2=0;
            for (int i = 0; i < (count/2)-1 ; i++)
            {
                sum1 +=(vector[x]* vector[x+3]);
                x+= 2;
                Console.WriteLine(sum1);
                sum2 += (vector[y] * vector[y + 1]);
                y+= 2;
                Console.WriteLine(sum2);
            }
            sum1 +=(vector[count-2] * vector[1]);
            sum2 +=(vector[count - 1] * vector[0]);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            square=Math.Abs((sum1 - sum2) / 2);

            return square;
        }

    }


}





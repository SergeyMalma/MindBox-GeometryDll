using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestFigureArea
{
    [TestClass]
    public class FigureAreaTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 10;
            double expected = (Math.Pow(radius, 2) * Math.PI);
            FigureArea.Circle circle = new FigureArea.Circle(radius);
            Assert.AreEqual(expected, circle.CircleArea());

        }
        [TestMethod]
        public void TestTriangleArea()
        {
            double side1 = 13;
            double side2 = 12;
            double side3 = 5;
            var perimeter = (side1 + side2 + side3) / 2d;
            double expected = (Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3)));
            FigureArea.Triangle triangle = new FigureArea.Triangle(side1, side2, side3);
            Assert.AreEqual(expected, triangle.TriangleArea());
        }
        [TestMethod]
        public void RightTriangleIsTrue()
        {
            double side1 = 13;
            double side2 = 12;
            double side3 = 5;
            bool expected = true;
            FigureArea.Triangle triangle = new FigureArea.Triangle(side1, side2, side3);

            Assert.AreEqual(expected, triangle.GetRightTriangle());

        }
        [TestMethod]
        public void RightTriangleIsFalse()
        {
            double side1 = 20;
            double side2 = 8;
            double side3 = 3;
            bool expected = false;
            FigureArea.Triangle triangle = new FigureArea.Triangle(side1, side2, side3);

            Assert.AreEqual(expected, triangle.GetRightTriangle());

        }
        [TestMethod]
        public void UnknowArea()
        {

            List<double> _list = new List<double>() {2,4,3,-8,1,2 };

            double expected = 7;


            FigureArea.UnknowFigure unknowFigure = new FigureArea.UnknowFigure(_list);
            Assert.AreEqual(expected, unknowFigure.UnknowFigureArea());
        }
    }
}

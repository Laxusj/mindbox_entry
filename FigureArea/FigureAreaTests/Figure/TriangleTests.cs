using FigureArea.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaTests.Figure
{
  public class TriangleTests
  {
    [Test]
    public void IsValid_InvalidSidesLengths_ReturnsFalse()
    {
      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(5, 5);

      var triangle = new Triangle(pointA, pointB, pointC);

      var isValid = triangle.IsValid;

      Assert.AreEqual(false, isValid);
    }

    [Test]
    public void IsValid_ValidSidesLengths_ReturnsTrue()
    {
      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(2, 2);

      var triangle = new Triangle(pointA, pointB, pointC);

      var isValid = triangle.IsValid;

      Assert.AreEqual(true, isValid);
    }

    [Test]
    public void IsRight_InvalidRightTriangleSides_ReturnsFalse()
    {
      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(2, 2);
      var triangle = new Triangle(pointA, pointB, pointC);

      var isRight = triangle.IsRight;

      Assert.AreEqual(false, isRight);
    }

    [Test]
    public void IsRight_ValidRightTriangleSides_ReturnsTrue()
    {
      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(0, 0);
      var triangle = new Triangle(pointA, pointB, pointC);

      var isRight = triangle.IsRight;

      Assert.AreEqual(true, isRight);
    }

    [Test]
    public void CalculateArea_ValidSidesLengths_ReturnsNonNegativeValue()
    {
      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(0, 0);
      var triangle = new Triangle(pointA, pointB, pointC);

      var trianlgeArea = triangle.CalculateArea();

      Assert.That(trianlgeArea >= 0);
    }

    [Test]
    public void CalculateArea_ValidSidesLengths_ReturnsRightValue1()
    {
      const double CALCULATING_AREA = 50;

      var pointA = new Point(0, 10);
      var pointB = new Point(10, 0);
      var pointC = new Point(0, 0);
      var triangle = new Triangle(pointA, pointB, pointC);

      var trianlgeArea = triangle.CalculateArea();

      Assert.AreEqual(CALCULATING_AREA, trianlgeArea);
    }

    [Test]
    public void CalculateArea_ValidSidesLengths_ReturnsRightValue2()
    {
      const double CALCULATING_AREA = 205;

      var pointA = new Point(10, 3);
      var pointB = new Point(3, 32);
      var pointC = new Point(-1, -10);
      var triangle = new Triangle(pointA, pointB, pointC);

      var trianlgeArea = triangle.CalculateArea(0);

      Assert.AreEqual(CALCULATING_AREA, trianlgeArea);
    }
  }
}

using NUnit.Framework;
using FigureArea.Figures;
using System;

namespace FigureAreaTests
{
  public class CircleTests
  {
    [Test]
    public void IsValid_NegativeRadius_ReturnsFalse()
    {
      const double NEGATIVE_RADIUS  = -1;
      var circle = new Circle(NEGATIVE_RADIUS);

      var isValid = circle.IsValid;

      Assert.AreEqual(false, isValid);
    }

    [Test]
    public void IsValid_NilRadius_ReturnsTrue()
    {
      var circle = new Circle(0);

      var isValid = circle.IsValid;

      Assert.AreEqual(true, isValid);
    }
    
    [Test]
    public void IsValid_PositiveRadius_ReturnsTrue()
    {
      const double POSITIVE_RADIUS = 1;
      var circle = new Circle(POSITIVE_RADIUS);

      var isValid = circle.IsValid;

      Assert.AreEqual(true, isValid);
    }

    [Test]
    public void CalculateArea_PositiveRadius_RetursCalculatedValue()
    {
      const double POSITIVE_RADIUS = 1;
      var circle = new Circle(POSITIVE_RADIUS);
      //var area = Math.PI * Math.Pow(POSITIVE_RADIUS, 2);

      var circleArea = circle.CalculateArea();

      Assert.That(circleArea > 0);
    }

    [Test]
    public void CalculateArea_NilRadius_RetursCalcuatedValue()
    {
      var circle = new Circle(0);

      var circleArea = circle.CalculateArea();

      Assert.That(circleArea >= 0);
    }

    [Test]
    public void CalculateArea_NegativeRadius_ReturnsMinusOne()
    {
      const double NEGATIVE_RADIUS = -1;
      var circle = new Circle(NEGATIVE_RADIUS);

      var circleArea = circle.CalculateArea();

      Assert.AreEqual(circleArea, -1);
    }

    [Test]
    public void CalculateArea_ValidRadius_ReturnRightValue1()
    {
      const double VALID_RADIUS = 10;
      var circle = new Circle(VALID_RADIUS);
      var value = Math.PI * Math.Pow(VALID_RADIUS, 2);

      var circleArea = circle.CalculateArea();

      Assert.AreEqual(circleArea, value);
    }

    [Test]
    public void CalculateArea_ValidRadius_ReturnRightValue2()
    {
      const double VALID_RADIUS = 344;
      var circle = new Circle(VALID_RADIUS);
      var value = Math.PI * Math.Pow(VALID_RADIUS, 2);

      var circleArea = circle.CalculateArea();

      Assert.AreEqual(circleArea, value);
    }
  }
}
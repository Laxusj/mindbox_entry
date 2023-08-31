using System;

namespace FigureArea.Figures
{
  public class Circle : IFigure
  {
    public Circle(double radius)
    {
      this.Radius = radius;
      this.IsValid = radius >= 0;
    }

    public double Radius { get; private set; }
    public bool IsValid { get; private set; }

    public double CalculateArea(int digits = -1)
    {
      if (!IsValid)
        return -1;

      var result = Math.PI * Math.Pow(Radius, 2);

      return digits > 0
        ? Math.Round(result, digits)
        : result;
    }
  }
}

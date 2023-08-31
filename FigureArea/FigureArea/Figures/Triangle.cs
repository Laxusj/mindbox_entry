using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using FigureArea.Extensions;

namespace FigureArea.Figures
{
  public class Triangle : IFigure
  {
    public Triangle(Point a, Point b, Point c)
    {
      this.A = a;
      this.B = b;
      this.C = c;

      this.IsValid = ValidateTriangle();
      this.IsRight = IsRightTriangle();
    }

    public Point A { get; private set; }
    public Point B { get; private set; }
    public Point C { get; private set; }
    public bool IsValid { get; private set; }
    public bool IsRight { get; private set; }

    public double CalculateArea(int digits = -1)
    {
      if (!IsValid)
        return -1;

      (double AB, double BC, double CA) = GetAllSideLengths();

      var p = (AB + BC + CA) / 2;

      var result = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));

      return digits > -1
        ? Math.Round(result, digits)
        : result;
    }
    private (double, double, double) GetAllSideLengths() =>
      (A.Distance(B), B.Distance(C), A.Distance(C));

    private bool IsRightTriangle()
    {
      (double AB, double BC, double CA) = GetAllSideLengths();

      var ABSquared = Math.Round(AB * AB, 5);
      var BCSquared = Math.Round(BC * BC, 5);
      var CASquared = Math.Round(CA * CA, 5);

      return ABSquared == BCSquared + CASquared ||
        BCSquared == ABSquared + CASquared ||
        CASquared == ABSquared + BCSquared;
    }
    private bool ValidateTriangle()
    {
      (double AB, double BC, double CA) = GetAllSideLengths();

      return AB + BC > CA && BC + CA > AB && AB + CA > BC;
    }
  }
}

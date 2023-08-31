using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigureArea.Extensions
{
  public static class PointExtensions
  {
    public static double Distance(this Point p1, Point p2) =>
      Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)));
  }
}

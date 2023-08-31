using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
  /// <summary>
  /// Интерфейс для объектов фигур.
  /// </summary>
  interface IFigure
  {
    /// <summary>
    /// Отражает признак корректности (возможности существования) фигуры.
    /// </summary>
    public bool IsValid { get; }

    /// <summary>
    /// Рассчитать площадь. 
    /// </summary>
    /// <param name="digits">Количество округляемых символов после запятой.</param>
    /// <returns>Площадь фигуры. -1 - если фигура не корректа.</returns>
    public double CalculateArea(int digits = -1);
  }
}

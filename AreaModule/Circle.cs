using System;

namespace AreaModule
{
  public class Circle : IAreaFigure
  {
    public double R{ get;private set; }

    public Circle(double r)
    {
      R=r;
    }

    public double Area()
    {
      return Math.PI*Math.Pow(R,2);
    }
  }
}

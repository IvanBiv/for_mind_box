using System;

namespace AreaModule
{
  public class Triangle : IAreaFigure
  {
    public double AB{get;private set;}
    public double BC{get;private set;}
    public double CA{get;private set;}

    public Triangle(Point a, Point b, Point c)
    {
      AB=Math.Sqrt(Math.Pow(b.X-a.X,2)+Math.Pow(b.Y-a.Y,2));
      BC=Math.Sqrt(Math.Pow(c.X-b.X,2)+Math.Pow(c.Y-b.Y,2));
      CA=Math.Sqrt(Math.Pow(a.X-c.X,2)+Math.Pow(a.Y-c.Y,2));
    }

    public Triangle(double ab, double bc, double ca)
    {
      AB=ab;
      BC=bc;
      CA=ca;
    }

    public double Area()
    {
      double p = (AB + BC + CA) / 2.0d;
      double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
      return S;
    }

    public bool IsRightTriangle(double delta=0.000001)
    {
      return Math.Abs(AB*AB+BC*BC-CA*CA)<delta || Math.Abs(BC*BC+CA*CA-AB*AB)<delta || Math.Abs(AB*AB+CA*CA-BC*BC)<delta;
    }
  }
}

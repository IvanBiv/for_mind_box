using System.Collections.Generic;

namespace AreaModule
{
  public class CustomFigure : IPointersFigure
  {
    private List<Point> _points;
    public IList<Point> Points{ get=>_points; }

    private CustomFigure(){}

    public CustomFigure(params Point[] points)
    {
      _points = new List<Point>(points);
    }
  }
}

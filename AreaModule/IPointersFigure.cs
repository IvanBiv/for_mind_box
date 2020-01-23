using System.Collections.Generic;

namespace AreaModule
{
  public interface IPointersFigure: IFigure
  {
    IList<Point> Points{get;}
  }
}

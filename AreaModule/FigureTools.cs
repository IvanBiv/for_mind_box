using System;
using System.Collections.Generic;

namespace AreaModule
{
    public class FigureTools
    {
        public double Area(IFigure figure)
        {
            if (figure is IAreaFigure)
            {
                return (figure as IAreaFigure).Area();
            }
            else if (figure is IPointersFigure)
            {
                return DefaultArea((figure as IPointersFigure).Points);
            }
            else
            {
                throw new Exception("I can't calc area for this figure.");
            }
        }

        private double DefaultArea(IList<Point> points)
        {
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < points.Count - 1; i++)
            {
                var point = points[i];
                var next_point = points[i+1];
                sum1 += point.X * next_point.Y;
                sum2 += point.Y * next_point.X;
            }

            return Math.Abs((sum1 - sum2) / 2);
        }
    }
}

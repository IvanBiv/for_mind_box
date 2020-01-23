using NUnit.Framework;

namespace AreaModule.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreaCircle_by_radius()
        {
            var figureTools = new FigureTools();
            var areaCircle = figureTools.Area(new Circle(1));

            Assert.AreEqual(areaCircle, System.Math.PI, 0.00001);
        }

        [Test]
        public void AreaTriangle_ISRightTriangle_true()
        {
            var figureTools = new FigureTools();
            var triangle = new Triangle(new Point(0,0), new Point(0,1), new Point(1,0));

            Assert.AreEqual(triangle.IsRightTriangle(), true);
        }

        [Test]
        public void AreaTriangle_ISRightTriangle_false()
        {
            var figureTools = new FigureTools();
            var triangle = new Triangle(1,1,1);

            Assert.AreEqual(triangle.IsRightTriangle(), false);
        }

        [Test]
        public void AreaTriangle_by_coord()
        {
            var figureTools = new FigureTools();
            var areaTriangle = figureTools.Area(new Triangle(new Point(0,0), new Point(0,1), new Point(1,0)));

            Assert.AreEqual(areaTriangle, 0.5, 0.00001);
        }

        [Test]
        public void AreaTriangle_by_size()
        {
            var figureTools = new FigureTools();
            var areaTriangle = figureTools.Area(new Triangle(1,1,1.414213562));

            Assert.AreEqual(areaTriangle, 0.5, 0.00001);
        }

        [Test]
        public void AreaCustomFigure_from_pointers()
        {
            var figureTools = new FigureTools();
            var areaCustom = figureTools.Area(new CustomFigure(new Point(0,0), new Point(0,1), new Point(1,0)));

            Assert.AreEqual(areaCustom, 0.5, 0.00001);
        }
    }
}
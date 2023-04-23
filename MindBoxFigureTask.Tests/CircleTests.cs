using MindBoxFigure;

namespace MindBoxFigureTask.Tests
{
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Тест для проверки вычисления площади круга по радиусу
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithValidRadius_ReturnsSquare()
        {
            double radius = 6d;
            var squareExpected = Math.PI * Math.Pow(radius, 2);
            var squareResult = new Circle(radius).Square();
            Assert.AreEqual(squareExpected, squareResult);
        }

        /// <summary>
        /// Тест для проверки вычисления площади круга с нулевым радиусом
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithZeroRadius_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                double zeroRadius = 0d;
                var square = new Circle(zeroRadius).Square;
            });
        }

        /// <summary>
        /// Тест для проверки вычисления площади круга с отрицательным радиусом
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithNegativeRadius_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                double zeroRadius = -1d;
                var square = new Circle(zeroRadius).Square;
            });
        }
    }
}
using MindBoxFigure;

namespace MindBoxFigureTask.Tests
{
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Тест для проверки вычисления площади несуществующего треугольника
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithInvalidSideA_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var sideA = 6d;
                var sideB = 3d;
                var sideC = 2d;
                var square = new Triangle(sideA, sideB, sideC).Square();
            });
        }

        /// <summary>
        /// Тест для проверки вычисления площади несуществующего треугольника
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithInvalidSideB_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var sideA = 2d;
                var sideB = 8d;
                var sideC = 1d;
                var square = new Triangle(sideA, sideB, sideC).Square();
            });
        }

        /// <summary>
        /// Тест для проверки вычисления площади несуществующего треугольника
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithInvalidSideC_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var sideA = 4d;
                var sideB = 3d;
                var sideC = 9d;
                var square = new Triangle(sideA, sideB, sideC).Square();
            });
        }

        /// <summary>
        /// Тест для проверки вычисления площади треугольника с корректными сторонами
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithValidSides_ReturnsSquare()
        {
            var sideA = 3d;
            var sideB = 6d;
            var sideC = 5d;

            var semiperimeter = 0.5d * (sideA + sideB + sideC);
            var squareExpected = Math.Sqrt(semiperimeter *
                            (semiperimeter - sideA) *
                            (semiperimeter - sideB) *
                            (semiperimeter - sideC));

            var squareResult = new Triangle(sideA, sideB, sideC).Square();
            Assert.AreEqual(squareExpected, squareResult);
        }

        /// <summary>
        /// Тест для проверки вычисления площади прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void CalculateSquare_RightTriangle_ReturnsSquare()
        {
            var sideA = 3d;
            var sideB = 4d;
            var sideC = 5d;

            var squareExpected = 0.5d * sideA * sideB;

            var squareResult = new Triangle(sideA, sideB, sideC).Square();
            Assert.AreEqual(squareExpected, squareResult);
        }


        /// <summary>
        /// Тест для проверки вычисления площади треугольника c отрицательной стороной
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithNegativeSides_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var sideA = 8d;
                var sideB = 4d;
                var sideC = -6d;
                var square = new Triangle(sideA, sideB, sideC).Square();
            });
        }

        /// <summary>
        /// Тест для проверки вычисления площади треугольника c нулевой стороной
        /// </summary>
        [TestMethod]
        public void CalculateSquare_WithZeroSides_ThrowException()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var sideA = 5d;
                var sideB = 0d;
                var sideC = 9d;
                var square = new Triangle(sideA, sideB, sideC).Square();
            });
        }

    }
}

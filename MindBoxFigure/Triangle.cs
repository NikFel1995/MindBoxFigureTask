namespace MindBoxFigure
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Виды треугольника
        /// </summary>
        public enum TriangleType
        {
            /// <summary>
            /// Не определен
            /// </summary>
            None,

            /// <summary>
            ///  Равносторонний
            /// </summary>
            Equilateral,

            /// <summary>
            ///  Равнобедренный
            /// </summary>
            Isosceles,

            /// <summary>
            ///  Разносторонний
            /// </summary>
            Scalene,
        }

        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA { get; init; }

        /// <summary>
        /// Сторона Б
        /// </summary>
        public double SideB { get; init; }

        /// <summary>
        /// Сторона С
        /// </summary>
        public double SideC { get; init; }

        /// <summary>
        /// Вид треугольника
        /// </summary>
        public TriangleType triangleType = TriangleType.None;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона Б</param>
        /// <param name="sideC">Сторона С</param>
        /// <exception cref="Exception">Если стороны равны и/или меньше нуля и/или треугольник является вырожденным</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsTriangle(sideA, sideB, sideC))
                throw new Exception("Треугольник не существует");


            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            GetTriangeType();
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        public double Square()
        {
            if (IsRightTriangle(out var legFirst, out var legSecond))
                return 0.5d * legFirst * legSecond;


            var semiperimeter = 0.5d * (SideA + SideB + SideC);
            var square = Math.Sqrt(semiperimeter *
                            (semiperimeter - SideA) *
                            (semiperimeter - SideB) *
                            (semiperimeter - SideC));

            return square;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <param name="legFirst">Первый катет</param>
        /// <param name="legSecond">Второй катет</param>
        /// <returns>True - является, иначе - False</returns>
        private bool IsRightTriangle(out double legFirst, out double legSecond)
        {
            legFirst = legSecond = 0d;

            if (SideA * SideA + SideB * SideB == SideC * SideC)
            {
                legFirst = SideA;
                legSecond = SideB;
                return true;
            }

            else if (SideA * SideA + SideC * SideC == SideB * SideB)
            {
                legFirst = SideA;
                legSecond = SideC;
                return true;
            }

            else if (SideA * SideB + SideC * SideC == SideA * SideA)
            {
                legFirst = SideC;
                legSecond = SideB;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        private bool IsTriangle(double sideA, double sideB, double sideC)
        {
            if ((sideA > 0d || sideB > 0d || sideC > 0d) &&
               (sideA < sideB + sideC &&
                sideB < sideA + sideC &&
                sideC < sideA + sideB))
                return true;

            return false;
        }

        /// <summary>
        /// Определение вида треугольника
        /// </summary>
        private void GetTriangeType()
        {

            if (SideA == SideB &&
                SideB == SideC &&
                SideA == SideC)
                triangleType = TriangleType.Equilateral;

            if (SideA == SideB ||
                SideB == SideC ||
                SideA == SideC)
                triangleType = TriangleType.Isosceles;

            else triangleType = TriangleType.Scalene;
        }

    }
}

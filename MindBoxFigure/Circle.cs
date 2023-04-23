namespace MindBoxFigure
{
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; init; }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="Radius">Радиус</param>
        /// <exception cref="Exception">Если радиус отрицательное число или равен нулю</exception>
        public Circle(double Radius)
        {
            if (!IsCircle(Radius))
                throw new Exception("Круг не существует");

            this.Radius = Radius;
        }

        /// <summary>
        /// Вычисление радиуса круга
        /// </summary>
        /// <returns>Радиус круга</returns>
        public double Square() => Math.PI * Radius * Radius;

        /// <summary>
        /// Проверка на существование круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        private bool IsCircle(double radius)
        {
            if (radius > 0d) return true;
            return false;
        }
    }
}

namespace Mindbox
{
    public class Calculator
    {
        private readonly IFigure _figure;

        public Calculator(IFigure figure)
        {
            _figure = figure;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public double CalculateArea()
        {
            return _figure.Area();
        }
    }
}

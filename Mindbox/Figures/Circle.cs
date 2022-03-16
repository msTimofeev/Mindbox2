﻿using System;

namespace Mindbox
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;

            Validate();
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        /// <summary>
        /// Валидация входных параметров
        /// </summary>
        private void Validate()
        {
            if (_radius < 0)
            {
                throw new ArgumentException("Радиус отрицательный");
            }
        }
    }
}

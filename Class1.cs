using System;

namespace ClassLibrary1
{
    public class Triangle
    {
        public  double _a { get; set; }
        public  double _b { get; set; } // стороны треугольника (a,b,c)
        public  double _c { get; set; } 

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a +c > b && b +c > a) // проверяем существует ли треугольник
            {
                _a = a;
                _b = b;
                _c = c;
            }
           
            else
            {
                throw new ArgumentException("Треугольника не существует");
            }
        }
        public  double SquareT() // площадь треугольника
        {
            

            var per = (_a + _b + _c) / 2;
            var next = per * (per - _a) * (per - _b) * (per - _c);
            return Math.Sqrt(next);

        }

        public bool IsoscelesT() // является ли треугольник прямоугольным
        {
            bool b = true; ;
            if (_a == _b || _a == _c || _b == _c)
                return b;
            else
                b = false;
            return b;
        }


    }

    public class Circle
    {
        public double _radius { get; set; }
        public Circle (double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(); // проверка на ввод радиуса меньше 0
            }
            _radius = radius;
        }

        public double AreaC() // площадь круга 
        {
            double s = 3.14 * Math.Pow(_radius, 2);
            return s;
        }
    }
}

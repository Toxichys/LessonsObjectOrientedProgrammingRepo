using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_6
{
    class Figure
    {
        public int _positionX;
        public int _positionY;
        public FigureColourEnum _colour;
        public bool _isVisible;
        public Figure(int positionX, int positionY, FigureColourEnum colour, bool visible)
        {
            _positionX = positionX;
            _positionY = positionY;
            _colour = colour;
            _isVisible = visible;
        }
        public void MoveX(int x)
        {
            _positionX += x;
        }
        public void MoveY(int y)
        {
            _positionY += y;
        }
        public void ChangeColour(FigureColourEnum colour)
        {
            _colour = colour;
        }
        public bool IsVisible()
        {
            return _isVisible;
        }
        public virtual void PrintParameters()
        {
            Console.WriteLine($"Значение позиции X {_positionX}  Y {_positionY}");
            Console.WriteLine($"Значение цвета {_colour}");
            Console.WriteLine($"Значение видимости {_isVisible}");
        }
    }
    public enum FigureColourEnum
    {
        red,
        green,
        blue
    }
    class Point : Figure
    {
        public Point(int positionX, int positionY, FigureColourEnum colour, bool visible) : base(positionX, positionY, colour, visible)
        {
        }
    }
    class Circle : Point
    {
        public double _radius;
        public Circle(int positionX, int positionY, FigureColourEnum colour, bool visible, double radius) : base(positionX, positionY, colour, visible)
        {
            _radius = radius;
        }
        public double Square()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        public override void PrintParameters()
        {
            base.PrintParameters();
            Console.WriteLine($"Значение радиуса {_radius}");
        }
    }
    class Rectangle : Point
    {
        public double _height;
        public double _width;
        public Rectangle(int positionX, int positionY, FigureColourEnum colour, bool visible, double height, double width) : base(positionX, positionY, colour, visible)
        {
            _height = height;
            _width = width;
        }
        public double Square()
        {
            return _height * _width;
        }
        public override void PrintParameters()
        {
            base.PrintParameters();
            Console.WriteLine($"Значение высоты {_height}");
            Console.WriteLine($"Значение ширины {_width}");
        }
    }
}

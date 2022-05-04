using System;

namespace MyHomework_Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
             * В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк.
             * Создать класс ACoder, реализующий интерфейс ICoder.
             * Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше. 
             * (В результате такого сдвига буква А становится буквой Б).
             * Создать класс BCoder, реализующий интерфейс ICoder. 
             * Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
             * расположенную в алфавите на i-й позиции с конца алфавита.
             * (Например, буква В заменяется на букву Э. Написать программу, демонстрирующую функционирование классов).
             */
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку для шифровки, дешифровки aCoder");
            string str = Console.ReadLine();

            ACoder aCoder = new();
            string strE = aCoder.Encode(str);
            string strD = aCoder.Decode(strE);
            Console.WriteLine("aCoder");
            Console.WriteLine("Строка зашифрованная: " + strE);
            Console.WriteLine("Строка дешифрованная: " + strD);

            BCoder bCoder = new();
            strE = bCoder.Encode(str);
            strD = bCoder.Decode(strE);
            Console.WriteLine("bCoder");
            Console.WriteLine("Строка зашифрованная: " + strE);
            Console.WriteLine("Строка дешифрованная: " + strD);
            /*
             * Создать класс Figure для работы с геометрическими фигурами.
             * В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
             * Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали,
             * изменение цвета, опрос состояния (видимый/невидимый).
             * Метод вывода на экран должен выводить состояние всех полей объекта.
             * Создать класс Point (точка) как потомок геометрической фигуры.
             * Создать класс Circle (окружность) как потомок точки.
             * В класс Circle добавить метод, который вычисляет площадь окружности.
             * Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
             * Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.
             * Подумать, какие методы можно объявить в интерфейсе, нужно ли объявлять абстрактный класс,
             * какие методы и поля будут в абстрактном классе, какие методы будут виртуальными, какие перегруженными.
             */
            Console.WriteLine("Задание 2");
            Point point = new Point(10, 15, FigureColourEnum.blue, true);
            point.MoveX(20);
            point.MoveY(-5);
            point.ChangeColour(FigureColourEnum.green);
            Console.WriteLine("Параметры точки");
            point.PrintParameters();

            Circle circle = new Circle(15, 15, FigureColourEnum.blue, true, 5);
            circle.MoveX(5);
            circle.MoveY(-5);
            circle.ChangeColour(FigureColourEnum.red);
            Console.WriteLine("Параметры круга");
            circle.PrintParameters();

            Rectangle rectangle = new Rectangle(25, 15, FigureColourEnum.green, true, 6, 7);
            rectangle.MoveX(-5);
            rectangle.MoveY(5);
            rectangle.ChangeColour(FigureColourEnum.blue);
            Console.WriteLine("Параметры прямоугольника");
            rectangle.PrintParameters();
        }
    }
}

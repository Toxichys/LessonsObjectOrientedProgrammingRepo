using System;

namespace MyHomework_Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах.
             * Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode().
             * Переопределить методToString() для печати информации о счете.
             * Протестировать функционирование переопределенных методов и операторов на простом примере.
             */
            Console.WriteLine("Задание 1");
            BankAccount bankAccount1 = new BankAccount(1500, BankAccount.TypesBankAccount.Deposit);
            BankAccount bankAccount2 = new BankAccount(3000, BankAccount.TypesBankAccount.Deposit);
            Console.WriteLine($"Сравнение на равенство {bankAccount1 == bankAccount2}");
            Console.WriteLine($"Сравнение на не равенство {bankAccount1 != bankAccount2}");
            Console.WriteLine($"Сравнение на Equals {bankAccount1.Equals(bankAccount2)}");
            Console.WriteLine($"GetHashCode для первого счета {bankAccount1.GetHashCode()} для втрого {bankAccount2.GetHashCode()}");
            Console.WriteLine($"Представлнение счета {bankAccount1.ToString()}");
            /*
             * Создать класс Figure для работы с геометрическими фигурами. 
             * В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». 
             * Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). 
             * Метод вывода на экран должен выводить состояние всех полей объекта. 
             * Создать класс Point (точка) как потомок геометрической фигуры. 
             * Создать класс Circle (окружность) как потомок точки. 
             * В класс Circle добавить метод, который вычисляет площадь окружности. 
             * Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника. 
             * Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.
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

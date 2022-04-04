using System;

namespace MyHomework_Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
             * Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
             * Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
             * Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
             * Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
             * и предусмотреть метод, который увеличивал бы значение этого поля.
             */
            BuildingClass building = new BuildingClass();
            building.Height = 30;
            building.CountFloor = 9;
            building.CountFlat = 108;
            building.CountEntrance = 3;
            Console.WriteLine($"Здание номе {building.Number}, высота этажей {building.GetHeightFloor()}, кол-во квартир в подъезде {building.GetFlatInEntrance()}, кол-во квартир на этаже {building.GetFlatInFloor()}");

            BuildingClass buildingTwo = new BuildingClass();
            Console.WriteLine($"Следующий дом с номером {buildingTwo.Number}");
        }
    }
}

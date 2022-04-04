using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_4
{
    class BuildingClass
    {
        /// <summary>
        /// Статическое поле, которое хранит последний использованный номер здания
        /// </summary>
        static int _counter = 0;
        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        private int _number;
        /// <summary>
        /// Высота здания
        /// </summary>
        private float _height;
        /// <summary>
        /// Количество этажей
        /// </summary>
        private int _countFloor;
        /// <summary>
        /// Количество квартир
        /// </summary>
        private int _countFlat;
        /// <summary>
        /// Количество подъездов
        /// </summary>
        private int _countEntrance;

        public int Number { get => _number; }
        public float Height { get => _height; set => _height = value; }
        public int CountFloor { get => _countFloor; set => _countFloor = value; }
        public int CountFlat { get => _countFlat; set => _countFlat = value; }
        public int CountEntrance { get => _countEntrance; set => _countEntrance = value; }

        /// <summary>
        /// Метод, который увеличивает значение статическое поля использованного номер здания
        /// и присвоение номара здания для объекта
        /// </summary>
        private void NewNumber()
        {
            _counter++;
            _number = _counter;
        }

        public BuildingClass()
        {
            NewNumber();
        }

        //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже
        /// <summary>
        /// Получаем высоту этаж
        /// </summary>
        /// <returns></returns>
        public float GetHeightFloor()
        {
            return _height / _countFloor;
        }

        /// <summary>
        /// Получаем количество квартир в подъезде (считаем, что количество квартир в подъездах одинаковое)
        /// </summary>
        /// <returns></returns>
        public int GetFlatInEntrance()
        {
            return _countFlat / _countEntrance;
        }

        /// <summary>
        /// Получаем количество квартир на этаже (считаем, что количество квартир на этажах одинаковое)
        /// </summary>
        /// <returns></returns>
        public int GetFlatInFloor()
        {
            return GetFlatInEntrance() / _countFloor;
        }
    }
}

using System;

namespace MyHomework_Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать класс рациональных чисел.
             *В классе два поля – числитель и знаменатель.
             *Предусмотреть конструктор.
             *Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --.
             *Переопределить метод ToString() для вывода дроби.
             *Определить операторы преобразования типов между типом дробь,float, int.
             *Определить операторы *, /, %.
             */
            RationalNumbersClass rationalNumber1 = new RationalNumbersClass(10, 2);
            RationalNumbersClass rationalNumber2 = new RationalNumbersClass(20, 4);
            RationalNumbersClass rationalNumber3 = new RationalNumbersClass(14, 4);
            Console.WriteLine($"Рациональное число 1: {rationalNumber1}");
            Console.WriteLine($"Рациональное число 2: {rationalNumber2}");
            Console.WriteLine($"Рациональное число 3: {rationalNumber3}");

            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на равенство: {rationalNumber1 == rationalNumber2}");
            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на неравенство: {rationalNumber1 != rationalNumber2}");
            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на меньше: {rationalNumber1 < rationalNumber2}");
            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на больше: {rationalNumber1 > rationalNumber2}");
            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на меньше или равно: {rationalNumber1 <= rationalNumber2}");
            Console.WriteLine($"Сравнение рациональных чисел 1 и 2 на больше или равном: {rationalNumber1 >= rationalNumber2}");

            Console.WriteLine($"Рациональное число 1 прибавить 2: {rationalNumber1 + rationalNumber2}");
            Console.WriteLine($"Рациональное число 2 вычесть 1: {rationalNumber2 - rationalNumber1}");
            Console.WriteLine($"Рациональное число 1 инкремент: {rationalNumber1++}");
            Console.WriteLine($"Рациональное число 1 декремент: {rationalNumber1--}");

            Console.WriteLine($"Преобразование из строки с дробь в тип рационального числа: {(RationalNumbersClass)"15/6"}");
            Console.WriteLine($"Преобразование из тип рационального числа в float : {(float)rationalNumber1}");
            Console.WriteLine($"Преобразование из тип рационального числа в int : {(int)rationalNumber1}");

            Console.WriteLine($"Рациональное число 1 умновить на число: {rationalNumber1 * 3}");
            Console.WriteLine($"Рациональное число 1 поделить на число: {rationalNumber1 / 3}");
            Console.WriteLine($"Остаток от деления рационального числа 1 на 2: {rationalNumber1 % rationalNumber3}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_5
{
    class RationalNumbersClass
    {
        private int _numerator;
        private uint _denominator;
        public int Numerator
        {
            get => _numerator;
            set => _numerator = value;
        }
        public uint Denominator
        {
            get => _denominator;
            set => _denominator = value;
        }
        public float Value { get => _numerator / _denominator; }
        public RationalNumbersClass(int numerator, uint denominator)
        {
            if (denominator == 0) throw new ArgumentException("denominator");
            _numerator = numerator;
            _denominator = denominator;
        }


        /*Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, –, ++, --.
         */
        public static bool operator ==(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return (RationalNumberOne.Numerator == RationalNumberTwo.Numerator && RationalNumberOne.Denominator == RationalNumberTwo.Denominator); ;
        }

        public static bool operator !=(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return (RationalNumberOne.Numerator != RationalNumberTwo.Numerator || RationalNumberOne.Denominator != RationalNumberTwo.Denominator); ;
        }

        public static bool operator <(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return RationalNumberOne.Value < RationalNumberTwo.Value;
        }

        public static bool operator >(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return RationalNumberOne.Value > RationalNumberTwo.Value;
        }

        public static bool operator <=(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return RationalNumberOne.Value <= RationalNumberTwo.Value;
        }

        public static bool operator >=(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return RationalNumberOne.Value >= RationalNumberTwo.Value;
        }

        public static RationalNumbersClass operator +(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return new RationalNumbersClass(RationalNumberOne.Numerator + RationalNumberTwo.Numerator, RationalNumberOne.Denominator + RationalNumberTwo.Denominator);
        }

        public static RationalNumbersClass operator -(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            if (RationalNumberOne.Denominator <= RationalNumberTwo.Denominator) throw new ArgumentException("denominator false");
            return new RationalNumbersClass(RationalNumberOne.Numerator - RationalNumberTwo.Numerator, RationalNumberOne.Denominator - RationalNumberTwo.Denominator);
        }

        public static RationalNumbersClass operator ++(RationalNumbersClass RationalNumber)
        {
            RationalNumber.Numerator++;
            RationalNumber.Denominator++;
            return RationalNumber;
        }

        public static RationalNumbersClass operator --(RationalNumbersClass RationalNumber)
        {
            RationalNumber.Numerator--;
            RationalNumber.Denominator--;
            return RationalNumber;
        }

        /*Переопределить метод ToString() для вывода дроби.
         */

        public override string ToString()
        {
            return _numerator.ToString() + "/" + _denominator.ToString();
        }

        /*Определить операторы преобразования типов между типом дробь,float, int.
         */

        public static explicit operator RationalNumbersClass(string fractional)
        {
            if (fractional.IndexOf("/") == -1) throw new ArgumentException("Нет дроби в строке");
            int numerator = int.Parse(fractional.Substring(0, fractional.IndexOf("/")));
            uint denominator = uint.Parse(fractional.Substring(fractional.IndexOf("/") + 1, fractional.Length - fractional.IndexOf("/") - 1));
            return new RationalNumbersClass(numerator, denominator);
        }

        public static explicit operator float(RationalNumbersClass RationalNumber)
        {
            return RationalNumber.Value;
        }

        public static explicit operator int(RationalNumbersClass RationalNumber)
        {
            return (int)RationalNumber.Value;
        }

        /*Определить операторы *, /, %.
         */

        public static RationalNumbersClass operator *(RationalNumbersClass RationalNumber, int scale)
        {
            return new RationalNumbersClass(RationalNumber.Numerator * scale, RationalNumber.Denominator);
        }

        public static RationalNumbersClass operator /(RationalNumbersClass RationalNumber, int scale)
        {
            return new RationalNumbersClass(RationalNumber.Numerator, RationalNumber.Denominator * (uint)scale);
        }

        public static float operator %(RationalNumbersClass RationalNumberOne, RationalNumbersClass RationalNumberTwo)
        {
            return RationalNumberOne.Value % RationalNumberTwo.Value;
        }
    }
}

using System;

namespace MyHomework_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ●	Создать класс счет в банке с закрытыми полями: номер счета,
             * баланс, тип банковского счета (использовать перечислимый тип).
             * Предусмотреть методы для доступа к данным – заполнения и чтения.
             * Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать
             */
            Console.WriteLine("Пункт 1 домашнего  задания");
            BankAccount firstAccount = new();
            firstAccount.SetNumber(1111111111);
            firstAccount.SetBalance(1000.0M);
            firstAccount.SetTypeBankAccount(TypesBankAccount.Settlement);
            Console.WriteLine($"Счет номер: {firstAccount.GetNumber()} баланс: {firstAccount.GetBalance()} тип: {firstAccount.GetTypeBankAccount()}");
            /*
             * ●	Изменить класс счет в банке из упражнения таким образом,
             * чтобы номер счета генерировался сам и был уникальным. 
             * Для этого надо создать в классе статическую переменную и метод,
             * который увеличивает значение этого переменной.
             */
            Console.WriteLine("Пункт 2 домашнего  задания");
            BankAccountTwo secondAccount = new();
            secondAccount.SetBalance(2000.0M);
            secondAccount.SetTypeBankAccount(TypesBankAccount.Settlement);
            Console.WriteLine($"Счет номер: {secondAccount.GetNumber()} баланс: {secondAccount.GetBalance()} тип: {secondAccount.GetTypeBankAccount()}");
            BankAccountTwo secondAccount2 = new();
            secondAccount2.SetBalance(3000.0M);
            secondAccount2.SetTypeBankAccount(TypesBankAccount.Settlement);
            Console.WriteLine($"Счет номер: {secondAccount2.GetNumber()} баланс: {secondAccount2.GetBalance()} тип: {secondAccount2.GetTypeBankAccount()}");
            /*
             * В классе банковский счет, удалить методы заполнения полей. 
             * Вместо этих методов создать конструкторы.
             * Переопределить конструктор по умолчанию, 
             * создать конструктор для заполнения поля баланс, 
             * конструктор для заполнения поля тип банковского счета, 
             * конструктор для заполнения баланса и типа банковского счета. 
             * Каждый конструктор должен вызывать метод, генерирующий номер счета.
             */
            Console.WriteLine("Пункт 3 домашнего  задания");
            BankAccountThree thirdAccount = new(3000.0M);
            Console.WriteLine($"Счет номер: {thirdAccount.GetNumber()} баланс: {thirdAccount.GetBalance()} тип: {thirdAccount.GetTypeBankAccount()}");
            BankAccountThree thirdAccount2 = new(TypesBankAccount.Settlement);
            Console.WriteLine($"Счет номер: {thirdAccount2.GetNumber()} баланс: {thirdAccount2.GetBalance()} тип: {thirdAccount2.GetTypeBankAccount()}");
            BankAccountThree thirdAccount3 = new(3000.0M, TypesBankAccount.Settlement);
            Console.WriteLine($"Счет номер: {thirdAccount3.GetNumber()} баланс: {thirdAccount3.GetBalance()} тип: {thirdAccount3.GetTypeBankAccount()}");
            /*
             * ●	В классе все методы для заполнения 
             * и получения значений полей заменить на свойства.
             * Написать тестовый пример.
             */
            Console.WriteLine("Пункт 4 домашнего  задания");
            BankAccountEnd fourthdAccount = new(3000.0M, TypesBankAccount.Budget);
            Console.WriteLine($"Счет номер: {fourthdAccount.Number} баланс: {fourthdAccount.Balance} тип: {fourthdAccount.TypeBankAccount}");
            /*
             * ●	(*)Добавить в класс счет в банке два метода:
             * снять со счета и положить на счет.
             * Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму,
             * и в случае положительного результата изменяет баланс.
             */
            Console.WriteLine("Пополнение счета");
            fourthdAccount.PutOnAccounts(100.0M);
            Console.WriteLine($"Счет номер: {fourthdAccount.Number} баланс: {fourthdAccount.Balance} тип: {fourthdAccount.TypeBankAccount}");
            Console.WriteLine("Списание со счета");
            fourthdAccount.DeductFromAccount(4000.0M);
            Console.WriteLine($"Счет номер: {fourthdAccount.Number} баланс: {fourthdAccount.Balance} тип: {fourthdAccount.TypeBankAccount}");
            Console.WriteLine("Списание со счета");
            fourthdAccount.DeductFromAccount(3000.0M);
            Console.WriteLine($"Счет номер: {fourthdAccount.Number} баланс: {fourthdAccount.Balance} тип: {fourthdAccount.TypeBankAccount}");
        }
    }
}

using System;
using System.IO;

namespace MyHomework_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * В класс банковский счет, созданный в упражнениях, добавить метод,
             * который переводит деньги с одного счета на другой.
             * У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
             */
            Console.WriteLine("Задание 1");
            BankAccount bankAccountOne = new BankAccount(15000.0M, BankAccount.TypesBankAccount.Settlement);
            BankAccount bankAccountTwo = new BankAccount(5000.0M, BankAccount.TypesBankAccount.Settlement);
            Console.WriteLine("Счета до транзакции:");
            Console.WriteLine($"Счет номер: {bankAccountOne.Number} баланс: {bankAccountOne.Balance} тип: {bankAccountOne.TypeBankAccount}");
            Console.WriteLine($"Счет номер: {bankAccountTwo.Number} баланс: {bankAccountTwo.Balance} тип: {bankAccountTwo.TypeBankAccount}");
            Console.WriteLine($"Транзакции: с {bankAccountTwo.Number} на {bankAccountOne.Number}");
            bankAccountTwo.TransferFromAccountToAccount(bankAccountOne, 1500.0M);
            Console.WriteLine("Счета после транзакции:");
            Console.WriteLine($"Счет номер: {bankAccountOne.Number} баланс: {bankAccountOne.Balance} тип: {bankAccountOne.TypeBankAccount}");
            Console.WriteLine($"Счет номер: {bankAccountTwo.Number} баланс: {bankAccountTwo.Balance} тип: {bankAccountTwo.TypeBankAccount}");
            /*
             * Реализовать метод, который в качестве входного параметра принимает строку string, возвращает строку типа string,
             * буквы в которой идут в обратном порядке. Протестировать метод.
             */
            Console.WriteLine("Задание 2");
            Console.WriteLine("Строка до");
            string str = "Вот проверочная строка для переворота";
            Console.WriteLine(str);
            string strAfter = ReverseString(str);
            Console.WriteLine("Строка после");
            Console.WriteLine(strAfter);

            /*
             * Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.
             * Разделителем между ФИО и адресом электронной почты является символ &:
             * Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru
             * Сформировать новый файл, содержащий список адресов электронной почты.
             * Предусмотреть метод, выделяющий из строки адрес почты. Методу в качестве параметра передается символьная строка s,
             * e-mail возвращается в той же строке s: public void SearchMail (ref string s).
            */
            Console.WriteLine("Задание 3");
            string path = @"FIO_email.txt";
            string[] readText = File.ReadAllLines(path);
            Program programClass = new Program();
            for (int i = 0; i < readText.Length; i++)
            {
                programClass.SearchMail(ref readText[i]);
            }
            string pathTwo = @"email.txt";
            File.WriteAllLines(pathTwo, readText);
        }
        static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
        public void SearchMail(ref string s)
        {
            s = s.Substring(s.IndexOf('&') + 1);
        }
    }
}

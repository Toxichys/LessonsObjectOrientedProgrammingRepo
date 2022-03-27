using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_2
{
    /// <summary>
    /// Класс счет в банке с автоматической нумерацией
    /// </summary>
    public class BankAccountTwo
    {
        static ulong _number = 2222222222;
        private decimal _balance;
        private TypesBankAccount _typeBankAccount;
        public ulong GetNumber()
        {
            return _number;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void SetBalance(decimal value)
        {
            _balance = value;
        }
        public TypesBankAccount GetTypeBankAccount()
        {
            return _typeBankAccount;
        }
        public void SetTypeBankAccount(TypesBankAccount value)
        {
            _typeBankAccount = value;
        }
        public BankAccountTwo()
        {
            _number++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_2
{
    /// <summary>
    /// Класс счет в банке с переопредленнымикострукторами
    /// </summary>
    public class BankAccountThree
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
        public TypesBankAccount GetTypeBankAccount()
        {
            return _typeBankAccount;
        }
        public BankAccountThree(decimal balance)
        {
            NewNumber();
            _balance = balance;
        }
        public BankAccountThree(TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _typeBankAccount = typeBankAccount;
        }
        public BankAccountThree(decimal balance, TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }
        private void NewNumber()
        {
            _number++;
        }
    }
}

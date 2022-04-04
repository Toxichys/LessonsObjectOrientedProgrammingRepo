using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_2
{
    /// <summary>
    /// Класс счет в банке со свойствами
    /// </summary>
    public class BankAccountEnd
    {
        static ulong _number = 2222222222;
        private decimal _balance;
        private TypesBankAccount _typeBankAccount;
        public ulong Number { get => _number; }
        public decimal Balance { get => _balance; }
        public TypesBankAccount TypeBankAccount { get => _typeBankAccount; }
        public BankAccountEnd(decimal balance)
        {
            NewNumber();
            _balance = balance;
        }
        public BankAccountEnd(TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _typeBankAccount = typeBankAccount;
        }
        public BankAccountEnd(decimal balance, TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }
        private void NewNumber()
        {
            _number++;
        }
        /// <summary>
        /// Метод пополнения счета
        /// </summary>
        /// <param name="value">Сумма пополнения</param>
        public void PutOnAccounts(decimal value)
        {
            _balance += value;
        }
        /// <summary>
        /// Метод списания со счета
        /// </summary>
        /// <param name="value">Сумма списания</param>
        public void DeductFromAccount(decimal value)
        {
            if (_balance < value)
                Console.WriteLine("На счете не достаточно средств");
            else
                _balance -= value;
        }
    }
}

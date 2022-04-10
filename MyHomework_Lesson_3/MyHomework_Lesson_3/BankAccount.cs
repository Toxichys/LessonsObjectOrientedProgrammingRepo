using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_3
{
    /// <summary>
    /// Класс счет в банке со свойствами
    /// </summary>
    class BankAccount
    {
        static ulong _counter = 2222222222;
        private ulong _number;
        private decimal _balance;
        private TypesBankAccount _typeBankAccount;
        public ulong Number { get => _number; }
        public decimal Balance { get => _balance; }
        public TypesBankAccount TypeBankAccount { get => _typeBankAccount; }
        public BankAccount(decimal balance)
        {
            NewNumber();
            _balance = balance;
        }
        public BankAccount(TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _typeBankAccount = typeBankAccount;
        }
        public BankAccount(decimal balance, TypesBankAccount typeBankAccount)
        {
            NewNumber();
            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }
        /// <summary>
        /// Перечисление типов банковских счетов
        /// </summary>
        public enum TypesBankAccount
        {
            Settlement = 1,
            Credit = 2,
            Deposit = 3,
            Budget = 4
        }
        /// <summary>
        /// Нумератор банковского счета
        /// </summary>
        private void NewNumber()
        {
            _number = _counter;
            _counter++;
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
        public bool DeductFromAccount(decimal value)
        {
            if (_balance < value)
                return false;
            else
            {
                _balance -= value;
                return true;
            }
        }
        public void TransferFromAccountToAccount(BankAccount bankAccount, decimal summa)
        {
            if (bankAccount.DeductFromAccount(summa))
                PutOnAccounts(summa);
        }
    }
}

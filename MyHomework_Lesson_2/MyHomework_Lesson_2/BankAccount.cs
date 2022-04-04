using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework_Lesson_2
{
    /// <summary>
    /// Класс счет в банк с методами заполнния иполучения
    /// </summary>
    public class BankAccount
    {
        private ulong _number;
        private decimal _balance;
        private TypesBankAccount _typeBankAccount;
        public ulong GetNumber()
        {
            return _number;
        }
        public void SetNumber(ulong value)
        {
            _number = value;
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
    }
    public enum TypesBankAccount
    {
        Settlement = 1,
        Credit = 2,
        Deposit = 3,
        Budget = 4
    }
}

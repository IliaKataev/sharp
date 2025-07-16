using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAcc
    {
        Guid accountNumber;
        string ownerName;
        decimal balance;

        public Guid AccountNumber 
        { 
            get { return accountNumber; } 
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public BankAcc(string ownerName, decimal balance)
        {
            this.accountNumber = Guid.NewGuid();
            this.ownerName = ownerName;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Пополнение: {amount}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть положительной");
            }
        }

        public void Withdraw (decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Сумма должна быть положительной");
            }
            else if(amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Снятие: {amount}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber.ToString()}");
            Console.WriteLine($"Владелец счета: {ownerName}");
            Console.WriteLine($"Баланс: {balance}");
        }
    }
}

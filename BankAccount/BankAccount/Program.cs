using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc("Ilia Kataev", 99999m);
            acc.Deposit(-100);
            acc.Deposit(100);
            acc.Withdraw(999);
            acc.Withdraw(-100);
            acc.Withdraw(100);
            acc.Deposit(1000);
            acc.ShowInfo();
        }
    }
}

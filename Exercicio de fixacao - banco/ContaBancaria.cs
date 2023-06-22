using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ExercicioDeFixacaoBanco
{
    internal class ContaBancaria
    {
        public string Name { get; private set; }
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }

        public ContaBancaria(string name, int accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }
        public ContaBancaria(string name, int accountNumber, double balance) : this (name, accountNumber)
        {
            Balance = balance;
        }

        public void AddBalance(double deposit)
        {
            Balance += deposit;
        }
        public void WithDrawBalance(double withdraw)
        {
            Balance = Balance - 5.0 - withdraw;
        }

        public double TotalBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return "Conta " + AccountNumber + ", Titular: " + Name + ", Saldo: $ " + TotalBalance().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

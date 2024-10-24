using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioFixaxao.Entities.Exceptions;

namespace ExercicioFixaxao.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {}
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("O depósito deve ser positivo.");
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0 )
            {
                throw new DomainException("A quantidade deve ser positivo.");
            }
            if (amount > Balance)
            {
                throw new DomainException("Saldo insuficiente");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("O saque ultrapassou o limite de saque.");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return 
            "New Balance: "
            + Balance
            ;
        }
    }
}
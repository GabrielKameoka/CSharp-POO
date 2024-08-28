using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio6_3
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public int Numero { get; set; }

        public ContaBancaria()
        {
            Titular = "Não informado";
            Saldo = 0;
            Numero = 000000000000000000000;
        }

        public ContaBancaria(string titular, double saldo, int numero)
        {
            Titular = titular;
            Saldo = saldo;
            Numero = numero;
        }
    }
}
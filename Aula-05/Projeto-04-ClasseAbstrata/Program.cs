using System;
namespace Projeto4_5;

class Program
{
    static void Main(string[] args)
    {
        Corrente c = new Corrente();

        c.Creditar(500);
        c.ExibirSaldo();
    }
}
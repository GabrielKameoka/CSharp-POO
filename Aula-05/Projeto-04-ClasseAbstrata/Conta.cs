using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto4_5;
public abstract class Conta//Não consigo instanciar esta classe, ou seja, esta classe só serve para ser herdada.
{
    protected decimal saldo;//Não quero que algo externo altere o meu saldo, porém, em classes derivadas a esta classe base sim.

    public abstract void Creditar(decimal valor);//É um método abstrato, ou seja, outras classes DEVEM herdar este método

    public void ExibirSaldo()
    {
        System.Console.WriteLine($"O seu saldo é: {saldo}");
    }
}

public class Corrente : Conta
{
    public override void Creditar(decimal valor)//Implementação do método abstrato obrigatório herdado da classe absstrata (override)
    {
        saldo += valor;
    }
}
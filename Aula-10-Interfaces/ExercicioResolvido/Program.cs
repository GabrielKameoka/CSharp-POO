using System;
using ExercicioResolvido.Interfaces;
using ExercicioResolvido.Services;
namespace ExercicioResolvido;
class Program
{
    static void Main(string[] args)
    {
        IFormaPagamento pagamentoCartao = new PagamentoCartao();
        pagamentoCartao.Pagar(100);
        Console.WriteLine(pagamentoCartao.ObterDescricao());

        IFormaPagamento pagamentoBoleto = new PagamentoBoleto();
        pagamentoBoleto.Pagar(50);
        Console.WriteLine(pagamentoBoleto.ObterDescricao());
    }
}
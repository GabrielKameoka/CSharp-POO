using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioResolvido.Interfaces;

namespace ExercicioResolvido.Services
{
    public class PagamentoCartao : IFormaPagamento
    {
        public string ObterDescricao()
        {
            return "Cartão de Crédito";
        }
        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento com cartão de crédito no valor de R$ {valor}");
        }
    }
}
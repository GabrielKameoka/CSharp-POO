using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioResolvido.Interfaces;

namespace ExercicioResolvido.Services
{
    public class PagamentoBoleto : IFormaPagamento
    {
        public string ObterDescricao()
        {
            return "Boleto Bancário";
        }

        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento com boleto no valor de R$ {valor}");
        }
    }
}
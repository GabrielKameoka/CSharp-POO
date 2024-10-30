using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioResolvido.Interfaces
{
    public interface IFormaPagamento
    {
        void Pagar(double valor);
        string ObterDescricao();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_parte1
{
    public class ComparaClass<TipoA, TipoB>
    {
        public void compara (TipoA n1, TipoB n2)
        {
            bool resultado;
            resultado = n1.Equals (n2);
            Console.WriteLine ($"Os parâmetros são: {resultado}.");
        } 
    }
}
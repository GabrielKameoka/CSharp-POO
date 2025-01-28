using System;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        ListaGenerica<int> listaInt = new ListaGenerica<int>();
        listaInt.Add(1);
        listaInt.Add(2);
        listaInt.Add(3);
        
        ListaGenerica<string> listaString = new ListaGenerica<string>();
        listaString.Add("Gabriel");
        listaString.Add("João");
        listaString.Add("Nélio");

        foreach (var index in listaString)
        {
            Console.WriteLine(index);
        }
    }
}
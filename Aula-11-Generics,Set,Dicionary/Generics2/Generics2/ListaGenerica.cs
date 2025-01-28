using System.Collections;

namespace Generics;

public class ListaGenerica<T> : IEnumerable<T>
{
    private List<T> itens = new List<T>();

    public void Add(T item)
    {
        itens.Add(item);
    }

    public T Get(int index)
    {
        return itens[index];
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return itens.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();

    }
}
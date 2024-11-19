namespace InterfaceIComparable.Entites;

public class Pessoa : IComparable
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        Pessoa outraPessoa = obj as Pessoa;
        if (outraPessoa != null)
            return this.Idade.CompareTo(outraPessoa.Idade);
        else
            throw new ArgumentException("Objeto não é do tipo Pessoa");
    }
}
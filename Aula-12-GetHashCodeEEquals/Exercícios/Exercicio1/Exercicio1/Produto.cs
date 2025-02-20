namespace Exercicio1;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Categoria { get; set; }

    public Produto(string nome, decimal preco, string categoria)
    {
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        
        Produto produto = (Produto)obj;
        return Nome == produto.Nome && Preco == produto.Preco && Categoria == produto.Categoria;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Nome.GetHashCode();
            hash = hash * 23 + Preco.GetHashCode();
            hash = hash * 23 + Categoria.GetHashCode();
            return hash;
        }
    }
}
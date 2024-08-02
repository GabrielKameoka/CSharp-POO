using System;

namespace Exercicio2_3
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Construtor padrão
        public Produto ()
        {
            _nome = "Produto não informado";
            _preco = 0;
            _quantidade = 0;
        }

        public string GetNome ()
        {
            return _nome;
        }

        public void SetNome (string nome)
        {
            _nome = nome;
        }
        
        public Produto (string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 10;
        }

        public Produto (string nome, double preco, int quandidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quandidade;
        }

        public void MostrarDetalhes ()
        {
            Console.WriteLine ($"Produto: {_nome}");
            Console.WriteLine ($"Preço: R$ {_preco}");
            Console.WriteLine ($"Quantidade em estoque: {_quantidade}");
        }
    }
}
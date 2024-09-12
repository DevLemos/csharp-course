using System.Globalization;

namespace this.entities
{
        class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    public Produto()
    {
        Quantidade = 0;
    }
    public Produto(string nome, double preco) : this()
    {
        Nome = nome;
        Preco = preco;
    }
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
}
}
using System.Globalization;

namespace sobrecarga.entities
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto()
        {
        }

        //Sobrecarga
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
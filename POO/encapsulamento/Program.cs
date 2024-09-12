using System;
using System.Globalization;
using encapsulamento.entities;

namespace encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.67, 2);
            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
        }
    }
}
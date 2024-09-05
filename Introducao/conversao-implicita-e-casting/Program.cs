using System;

namespace conversao_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo 1
            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            //exemplo 2
            double l;
            int c;
            l = 5.1;
            c = (int)l;
            Console.WriteLine(c);

            //exemplo 3
            int j = 5;
            int k = 2;
            double resultado = (double)j / k;
            Console.WriteLine(resultado);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor = 0, segundoValor = 1, proximoValor, n = 10;
            bool verificador = false;

            for (int i = 0; i < n; i++)
            {
                proximoValor = primeiroValor;
                primeiroValor = segundoValor;
                segundoValor = proximoValor + primeiroValor;

                if(segundoValor == n)
                {
                    verificador = true;
                }

                Console.WriteLine(proximoValor);
            }

            Verificar(verificador, n);
        }

        static void Verificar(bool verif, int n)
        {
            if (verif)
            {
                Console.WriteLine($"\t{n} - O valor está na sequência!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\t{n} - O valor NÃO está na sequência!");
            }
        }

    }
}

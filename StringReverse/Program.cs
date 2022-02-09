using System;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "Mundo Mundo Mundo";
            string palavraInvertida = "";

            for(int i = palavra.Length; i > 0; i--)
            {
                palavraInvertida += palavra[i - 1];
            }
            Console.WriteLine(palavraInvertida);
        }
    }
}

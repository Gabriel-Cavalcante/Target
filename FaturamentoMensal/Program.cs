using System;

namespace FaturamentoMensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SP = 67836.43;
            double RJ = 36678.66;
            double MG = 29229.88;
            double ES = 27165.48;
            double Outros = 19849.53;

            double valorTotal;

            valorTotal = SP + RJ + MG + ES + Outros;

            SP = SP * 100 / valorTotal;
            RJ = RJ * 100 / valorTotal;
            MG = MG * 100 / valorTotal;
            ES = ES * 100 / valorTotal;
            Outros = Outros * 100 / valorTotal;

            Console.WriteLine($"SP :        {SP.ToString("F")}%");
            Console.WriteLine($"RJ :        {RJ.ToString("F")}%");
            Console.WriteLine($"MG :        {MG.ToString("F")}%");
            Console.WriteLine($"ES :        {ES.ToString("F")}%");
            Console.WriteLine($"Outros :    {Outros.ToString("F")}%");

        }
    }
}

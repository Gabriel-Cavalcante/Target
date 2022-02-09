using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace FaturamentoDiario
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double menorValor = 1000000, maiorValor = 0, media = 0;
            int piorDia = 0, melhorDia = 0, quantidadeDiasMedia = 0, faturamentoAcimaMedia = 0;

            string basePath = Environment.CurrentDirectory;
            string relativePath = "dados/dados.json";

            string fullPath = Path.GetFullPath(relativePath, basePath);

            string jsonString = File.ReadAllText(fullPath);

            using var jsonDocument = JsonDocument.Parse(jsonString);

            var rootElement = jsonDocument.RootElement;

            var JsonElement = rootElement.EnumerateArray();

            foreach (var dia in JsonElement)
            {
                var diaElement = dia.GetProperty("dia");
                var dia1 = diaElement.GetInt32();

                var valorElement = dia.GetProperty("valor");
                var valor1 = valorElement.GetDouble();

                if (valor1 != 0 && valor1 < menorValor)
                {
                    menorValor = valor1;
                    piorDia = dia1;
                }

                if (valor1 != 0 && valor1 > maiorValor)
                {
                    maiorValor = valor1;
                    melhorDia = dia1;
                }

                if(valor1 != 0)
                {
                    media += valor1;
                    quantidadeDiasMedia += 1;
                }
            }

            media = media / quantidadeDiasMedia;

            foreach (var dia in JsonElement)
            {
                var diaElement = dia.GetProperty("dia");
                var dia1 = diaElement.GetInt32();

                var valorElement = dia.GetProperty("valor");
                var valor1 = valorElement.GetDouble();

                if (valor1 > media)
                {
                    faturamentoAcimaMedia += 1; 
                }
            }
            Console.WriteLine($"O menor faturamento do mês foi no dia {piorDia} representando {menorValor.ToString("C")}");
            Console.WriteLine($"O maior faturamento do mês foi no dia {melhorDia} representando {maiorValor.ToString("C")}");
            Console.WriteLine($"{faturamentoAcimaMedia} dias com faturamento acima da média.");
        }
    }
    
}

using _03_Exercicio.Classes;
using _03_Exercicio.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 3 **********");

        ICalcularImpostoPais calculo = new CalculaImpostoBrazil
        {
            TotalRenda = 1000,
            TotalDeducao = 100
        };

        var calcularImposto = new CalcularImposto();
        var valorTotalImposto = calcularImposto.Calcular(calculo);

        Console.WriteLine($"Brazil {valorTotalImposto}");

        Console.ReadLine();
    }
}
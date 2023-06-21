using _01_Exercicio.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 1 **********");

        var cliente = LocalizaCliente.ProcuraPorNome("Paulo");

        Console.WriteLine(cliente?.Nome ?? "Não localizado");

        Console.ReadLine();
    }
}
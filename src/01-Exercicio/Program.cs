using _01_Exercicio.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 1 **********");

        var resultado = Cliente.ObterListaDeClientes();
        Console.WriteLine();

        try
        {
            ExportarDados.ExportarArquivo(resultado);
            Console.WriteLine("Gerando arquivo com lista de clientes!");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Erro ao gerar arquivo com lista de Clientes: {exception}");
        }

        Console.ReadLine();
    }
}
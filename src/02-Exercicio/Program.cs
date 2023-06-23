using _02_Exercicio.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 2 **********");

        var meuLogArquivo = new FileLogger();
        var meuLogConsole = new ConsoleLogger();

        var pedido = new Pedido(meuLogArquivo);
        pedido.AdicionarPedido();

        Console.WriteLine();
        Console.WriteLine("Arquivo adicionado com sucesso: " + meuLogConsole.ToString());

        Console.ReadLine();
    }
}
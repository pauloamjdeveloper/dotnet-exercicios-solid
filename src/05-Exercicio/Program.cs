using _05_Exercicio.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 5 **********");

        var p1 = new Pizzaria(new PizzaFactory());
        p1.CriarPizza("mussarela");
        p1.CriarPizza("calabresa");

        Console.ReadLine();
    }
}
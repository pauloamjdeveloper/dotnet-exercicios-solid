using _04_Exercicio.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Exercício 4 **********");

        Produto celularSamsung = new Celular(new PromocaoDiaMaes());
        celularSamsung.Nome = "Celular Samsung Galaxy M10";
        celularSamsung.Preco = 1000;
        var precoCelular = celularSamsung.PrecoVenda();
        Console.WriteLine($"{celularSamsung.Nome} (20% Off) : {precoCelular}");

        Produto perfumeChanel = new Perfume(new PromocaoDiaNamorados());
        perfumeChanel.Nome = "Perfume Chanel Blue";
        perfumeChanel.Preco = 500;
        var precoChanel = perfumeChanel.PrecoVenda();
        Console.WriteLine($"{perfumeChanel.Nome} (10% Off) : {precoChanel}");

        Console.ReadLine();
    }
}
namespace _03_Exercicio.Interfaces
{
    public interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalDeducao { get; set; }

        decimal CalcularValorImposto();
    }
}
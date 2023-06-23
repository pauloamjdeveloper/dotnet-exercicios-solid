using _03_Exercicio.Interfaces;

namespace _03_Exercicio.Classes
{
    public class CalculaImpostoUSA : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 30 / 100;
        }
    }
}
using _03_Exercicio.Interfaces;

namespace _03_Exercicio.Classes
{
    public class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais calcularImpostoPais)
        {
            return calcularImpostoPais.CalcularValorImposto();
        }
    }
}

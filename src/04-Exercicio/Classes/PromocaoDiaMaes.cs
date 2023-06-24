using _04_Exercicio.Interfaces;

namespace _04_Exercicio.Classes
{
    public class PromocaoDiaMaes : IPromocao
    {
        public decimal Desconto()
        {
            return 0.20M;
        }
    }
}

using _04_Exercicio.Interfaces;

namespace _04_Exercicio.Classes
{
    public class PromocaoDiaNamorados : IPromocao
    {
        public decimal Desconto()
        {
            return 0.10M;
        }
    }
}

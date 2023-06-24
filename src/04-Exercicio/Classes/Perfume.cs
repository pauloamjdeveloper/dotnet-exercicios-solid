using _04_Exercicio.Interfaces;

namespace _04_Exercicio.Classes
{
    public class Perfume : Produto
    {
        public Perfume(IPromocao PromocaoDiaNamorados) : base(PromocaoDiaNamorados) { }
    }
}

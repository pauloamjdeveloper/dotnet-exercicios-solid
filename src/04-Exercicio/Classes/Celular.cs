using _04_Exercicio.Interfaces;

namespace _04_Exercicio.Classes
{
    public class Celular : Produto
    {
        public Celular(IPromocao PromocaoDiaMaes) : base(PromocaoDiaMaes) { }
    }
}

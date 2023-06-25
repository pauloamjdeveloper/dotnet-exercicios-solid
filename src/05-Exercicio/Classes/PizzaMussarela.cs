namespace _05_Exercicio.Classes
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome) { }

        public override int AssarPizza()
        {
            var tempo = 20;
            Console.WriteLine($"Assando a pizza de {Nome} por {tempo} minutos.");
            return tempo;
        }
    }
}

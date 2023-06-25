namespace _05_Exercicio.Classes
{
    public abstract class Pizza
    {
        public string Nome { get; set; }

        public abstract int AssarPizza();

        protected Pizza(string nome)
        {
            Nome = nome;
        }

        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Nome}");
        }
    }
}

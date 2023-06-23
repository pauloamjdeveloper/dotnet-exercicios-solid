using _02_Exercicio.Interfaces;

namespace _02_Exercicio.Classes
{
    public class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

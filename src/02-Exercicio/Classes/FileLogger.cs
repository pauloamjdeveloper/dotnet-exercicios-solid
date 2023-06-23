using _02_Exercicio.Interfaces;

namespace _02_Exercicio.Classes
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            var nomeDoArquivo = "LogOcorrencias";
            var tipoDoArquivo = ".txt";
            File.WriteAllText(@"C:\dados\" + nomeDoArquivo + tipoDoArquivo, mensagem);
        }
    }
}
using System.Text;

namespace _01_Exercicio.Classes
{
    public class ExportarDados
    {
        public static string ExportarArquivo(List<Cliente> dados) 
        {
            var stringBuilder = new StringBuilder();

            foreach(var item in dados) 
            {
                stringBuilder.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                stringBuilder.AppendLine();
            }

            File.AppendAllText(CriarArquivo(), stringBuilder.ToString());

            return stringBuilder.ToString();
        }

        private static string CriarArquivo() 
        {
            var nomeDoArquivo = "lista_de_clientes";
            var tipoDoArquivo = ".csv";
            var caminhoDoArquivo = @"C:\dados\" + nomeDoArquivo + tipoDoArquivo;

            return caminhoDoArquivo;
        }
    }
}
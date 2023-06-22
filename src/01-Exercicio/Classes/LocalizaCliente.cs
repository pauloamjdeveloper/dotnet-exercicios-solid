namespace _01_Exercicio.Classes
{
    public class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            var resultado = Cliente.ObterListaDeClientes().Find(n => n.Pais == pais);
            return resultado;
        }

        public static Cliente ProcuraPorNome(string nome)
        {
            var resultado = Cliente.ObterListaDeClientes().Find(n => n.Nome == nome);
            return resultado;
        }
    }
}

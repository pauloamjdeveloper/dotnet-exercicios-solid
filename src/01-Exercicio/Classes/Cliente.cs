namespace _01_Exercicio.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }

        public static List<Cliente> GetClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>()
            {
                new Cliente
                {
                    Nome="Paulo", Pais="Brasil", Email="paulo@email.com"
                },
                new Cliente
                {
                    Nome="Isadora", Pais="Chile", Email="isadora@email.com"
                }
            };
            return listaClientes;
        }
    }
}

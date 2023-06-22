namespace _01_Exercicio.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }

        public static List<Cliente> ObterListaDeClientes()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente{ Nome="Paulo", Pais="Brasil", Email="paulo@email.com" },
                new Cliente{ Nome="Isadora", Pais="Chile", Email="isadora@email.com" },
                new Cliente{ Nome="Sofia", Pais="Paraguai", Email="sofia@email.com" },
                new Cliente{ Nome="Florencio", Pais="Chile", Email="florencio@email.com" }
                
            };
            return listaClientes;
        }
    }
}

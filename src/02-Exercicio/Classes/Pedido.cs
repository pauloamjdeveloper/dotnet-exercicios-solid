namespace _02_Exercicio.Classes
{
    public class Pedido
    {
        private ConsoleLogger log = new ConsoleLogger();

        public virtual void AdicionarPedido()
        {
            try
            {
                log.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                log.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}

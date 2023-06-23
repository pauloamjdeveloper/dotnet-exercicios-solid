using _02_Exercicio.Interfaces;

namespace _02_Exercicio.Classes
{
    public class Pedido
    {
        private ILogger _log;

        public Pedido(ILogger log)
        {
            _log = log;
        }

        public virtual void AdicionarPedido()
        {
            try
            {
                _log.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception exception)
            {
                _log.Registrar($"{exception} - {DateTime.Now}");
            }
        }
    }
}

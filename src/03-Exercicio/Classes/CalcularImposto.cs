namespace _03_Exercicio.Classes
{
    public class CalcularImposto
    {
        public static decimal Calcular(decimal valor, decimal deducao, string pais)
        {
            decimal valorImposto = 0;
            decimal valorBase = valor - deducao;
            switch (pais)
            {
                case "Brazil":
                    break;
                case "USA":
                    break;
                case "UK":
                    break;
            }
            return valorImposto;
        }
    }
}

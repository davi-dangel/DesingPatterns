using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Frango : IIngrediente
    {
        public double Valor => 0.12;
        public double CalculaPreco(Lanche lanche) => lanche.Peso * Valor;
    }
}

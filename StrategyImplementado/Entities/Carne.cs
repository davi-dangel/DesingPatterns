using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Carne : IIngrediente
    {
        public double Valor => 0.2;

        public double CalculaPreco(Lanche lanche) => lanche.Peso * Valor;
    }
}

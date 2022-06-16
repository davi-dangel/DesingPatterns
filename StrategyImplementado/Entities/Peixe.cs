using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Peixe : IIngrediente
    {
        public double Valor => 0.16;
        public double CalculaPreco(Lanche lanche) => lanche.Peso * Valor;
    }
}

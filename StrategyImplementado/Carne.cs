using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Carne : IPreco, IIngrediente
    {
        public double Valor => 0.2;

        public double Calcula(Lanche lanche) => lanche.Peso * Valor;
    }
}

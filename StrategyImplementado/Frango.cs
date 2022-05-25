using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Frango : IPreco, IIngrediente
    {
        public double Valor => 0.12;

        public double Calcula(Lanche lanche) => lanche.Peso * Valor;
    }
}

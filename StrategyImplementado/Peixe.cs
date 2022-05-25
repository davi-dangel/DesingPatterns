using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Peixe : IPreco, IIngrediente
    {
        public double Valor => 0.16;

        public double Calcula(Lanche lanche) => lanche.Peso * Valor;
    }
}

namespace StrategyImplementado.Interfaces
{
    public interface IIngrediente
    {
        public double Valor { get; }
        public double CalculaPreco(Lanche lanche);
    }
}

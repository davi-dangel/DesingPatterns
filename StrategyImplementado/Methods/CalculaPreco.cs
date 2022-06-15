namespace StrategyImplementado.Methods
{
    public static class CalculaPreco
    {
        public static double CalculaPrecoLanche(this Lanche lanche)
        {
            return lanche.Peso * lanche.IngredientePrincipal.Valor;
        }
    }
}

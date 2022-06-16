using StrategyImplementado.Interfaces;

namespace StrategyImplementado
{
    public class Lanche
    {
        public string Nome { get; private set; }
        public IIngrediente IngredientePrincipal { get; private set; }
        public double Peso { get; private set; }
        public double Preco { get; private set; }

        public Lanche(string nome, IIngrediente ingredientePrincipal, double peso)
        {
            Nome = nome;
            IngredientePrincipal = ingredientePrincipal;
            Peso = peso;
            Preco = IngredientePrincipal.CalculaPreco(this);
        }
    }
}

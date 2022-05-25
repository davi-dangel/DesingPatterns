namespace StrategyNaoImplementado
{
    public class Lanche
    {
        public string Nome { get; set; }
        public string IngredientePrincipal { get; set; }
        public double Peso { get; set; }

        public Lanche(string nome, string ingredientePrincipal, double peso)
        {
            Nome = nome;
            IngredientePrincipal = ingredientePrincipal;
            Peso = peso;
        }
    }
}

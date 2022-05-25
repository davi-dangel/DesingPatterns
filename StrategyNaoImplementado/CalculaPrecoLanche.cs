namespace StrategyNaoImplementado
{
    public class CalculaPreco
    {
        public void CalculaPrecoLanche(string ingrediente, double peso)
        {
            if (ingrediente == "Carne")
            {
                double preco = peso * 0.2;
                Console.WriteLine($"Preço: {preco}");
            }
            else if (ingrediente == "Frango")
            {
                double preco = peso * 0.12;
                Console.WriteLine($"Preço: {preco}");
            }
            else if (ingrediente == "Peixe")
            {
                double preco = peso * 0.16;
                Console.WriteLine($"Preço: {preco}");
            }
        }
    }
}

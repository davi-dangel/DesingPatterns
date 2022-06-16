/*
 * Strategy Pattern Implementado
 * 
 */

using StrategyImplementado;

Lanche lanche = new("XSalada", new Carne(), 180.0);
lanche.SetPreco(lanche.IngredientePrincipal.CalculaPreco(lanche));
Console.WriteLine(lanche.Preco);
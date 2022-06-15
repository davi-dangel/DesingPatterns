/*
 * Strategy Pattern Implementado
 * 
 */

using StrategyImplementado;
using StrategyImplementado.Methods;

Lanche lanche = new("XSalada", new Carne(), 180.0);
lanche.SetPreco(lanche.CalculaPrecoLanche());
Console.WriteLine(lanche.Preco);
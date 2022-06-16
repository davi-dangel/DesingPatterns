/*
 * Strategy Pattern Implementado
 * 
 */

using StrategyImplementado;

Lanche lanche = new("XSalada", new Carne(), 180.0);
Console.WriteLine(lanche.Preco);
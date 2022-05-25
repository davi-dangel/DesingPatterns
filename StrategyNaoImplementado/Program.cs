/*
 * Strategy Pattern Não Implementado
 *
 * Premissa:
 *      Você possui uma lanchote e ao cadastrar um novo item no cardápio o sistema deverá
 *      calcular o preço do lanche com base no tamanho(peso) e no ingrediente do amburguer.
 *      
 * Problemas no Código Atual:
 *      Toda vez que um haburguer novo for adicionado precisaremos adicionar mais condicionais
 *      ao calculaPrecoLanche. Além disso, toda vez que um valor for alterado teremos que revisar todo
 *      o código.
 *      
 *      Para arrumar isso o método usado será o strategy, que consistem em .....
 *      TODO: Terminar esse texto e estudar melhor a teoria do Strategy
 * 
 */


using StrategyNaoImplementado;

Lanche lanche = new Lanche("XSalada", "Carne", MedidasLanche.Medio);

CalculaPreco CalculaPreco = new CalculaPreco();
CalculaPreco.CalculaPrecoLanche(lanche.IngredientePrincipal, lanche.Peso);
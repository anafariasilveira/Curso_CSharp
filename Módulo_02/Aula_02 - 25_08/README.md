# **Lista de exercícios - Aula 02** 💡
 
### *Exercício 01 - Aula:*

Crie uma interface Exercicio contendo os contratos para:
                
* FazerProva - implementado
* FazerTreino - implementado
* FazerFortalecimento - contrato
* FazerAlongamento - contrato

Crie uma classe Natacao que implemente os métodos: 
* Fortalecimento -> Malhar membros superiores e inferiores
* Alongamento -> Alongar membros superiores e inferiores 

Crie uma classe CorridaObstaculos que implemente os métodos: 
* Fortalecimento -> Malhar membros inferiores
* Alongamento -> Alongar membros inferiores

Crie uma classe de teste.


 ### *Exercício 01 - LMS:*

Considerando a classe abstrata AnimalBase e a classe Cachorro, realize a conversão da classe abstrata para uma interface chamada IAnimal. 
Essa nova interface deverá ser implementada pela classe Cachorro. 

### *Exercício 02 - LMS:*

Crie a interface IData que fornece os métodos: 
* void  setData(DateTime  data), que ajusta a data do objeto;
* DateTime  getData(), que retorna a data do objeto;
* string  dataString, que retorna a data do objeto como uma string.

Crie uma classe Produto que possui nome, valor e data de validade.
Crie uma classe Venda que possui data e produto. 
Produto e Venda implementam a interface IData. Crie uma classe estática chamada TestarVenda e um método estático chamado 
DetalhesVenda que recebe uma Venda e retorna uma string com os dados da venda.

Exemplo:

* Produto produto = new Produto();
* produto.nome = "Leite Integral";
* produto.valor = 5;
* produto.setData(new DateTime(2023, 3, 1));
* Venda venda = new Venda();
* venda.produto = produto;
* venda.setData(DateTime.Now);
* TestarVenda.DetalhesVenda(venda);
*"Data da venda: 29/10/2022 - Produto: Leite Integral - Valor do produto: 5 - Vencimento: 01/03/2023"*

*Dica: no método para converter a data para string utilize .ToString("dd/MM/yyyy")*

### *Exercício 05 - LMS:*

Uma interface define um contrato. Qualquer classe que implemente esse contrato deve fornecer implementações dos membros definidos na interface.

Crie um programa em C# que contenha uma interface IVeiculo com dois métodos, um para Dirigir do tipo string e outro para Reabastecer 
do tipo bool que tenha um parâmetro do tipo int com a quantidade de gasolina a ser reabastecida.

Em seguida, crie uma classe Carro com um construtor que receba um parâmetro com a quantidade de gasolina inicial do carro e implemente os métodos 
Dirigir e Reabastecer do carro.

O método Dirigir retornará "Dirigindo", se a gasolina for maior que 0. O método Reabastecer aumentará a gasolina do carro e retornará true.

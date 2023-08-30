# Lista de exercícios - Aula 03 💡

### *Exercício 01 - Aula:* 


### *Exercício 01 - LMS:*

Utilizando Reflections, além de termos a possibilidade de selecionar membros específicos de uma classe em tempo de execução, 
podemos retornar todos os membros públicos da mesma (propriedade, campos e metodos).

Considerando a classe a seguir, crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome 
de RetornaNome. Este método receberá um objeto (tipo object) e retornará uma lista de strings com os nomes dos membros públicos 
(propriedade, campos e metodos) pertencentes à esse objeto.

### *Exercício 03 - LMS:*

Neste exercício você deve criar uma classe estática com o nome Reflection e um método estático com o nome ConcatStringMembers, 
que receberá um objeto e retornará uma string com os resultados de todos os membros de um objeto, que são/retornam strings.

Use apenas os próprios métodos do objeto e não os métodos derivados. Considere somente os métodos sem parâmetros. 
Cada método (o método! NÃO o retorno do método!) deve ser considerado apenas uma vez. Para objetos nulos, retorne uma string vazia.

### *Exercício 05 - LMS:*

Reflections é algo interessante que o C# fornece, com ela podemos escrever código o qual lê as informações do metadado dos objeto em tempo de execução. Essas informações são toda a estrutura existente na classe, portanto métodos, propriedades e até mesmo atributos de classes e métodos são visualizadas.

Escreva uma classe estática chamada Utils e um método estático chamado isClass que receba um objeto e verifique se esse objeto é uma classe. Retorne um bool como resposta.

### *Exercício 06 - LMS:*

Considerando a classe a seguir, crie uma classe estática chamada Reflections e nessa classe crie um método estático com o nome de RetornaPropriedadesPublicas. Este método receberá objeto (tipo object) e retornará uma lista de strings com os nomes das propriedades publicas pertencentes a esse objeto.

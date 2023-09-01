# Lista de exercícios - Aula 04 💡

### *Exercício 01:*

Crie uma classe Empresa que possua os dados básicos de uma empresa como propriedades.
* Construa um método para imprimir as informações da empresa.
* Construa um método abstrato void RealizarVenda();

Crie uma classe Varejo que implemente o método abstrato para imprimir que vende produtos.
Crie uma classe Empreiteira que implemente o método abstrato para imprimir que vende serviços.

Na main, crie um objeto de cada classe, preenchendo as propriedades e invocando os métodos.

### *Exercício 02:*

Faça o mesmo exercício aplicando Interfaces.
Crie a classe base para herdar as propriedades porém façam os métodos através de implementação de Interface.

Na main, crie uma lista de interface.
Adicione um objeto de cada classe do tipo da interface, preenchendo as propriedades
Invoque os métodos da lista.

### *Exercício 02 - LMS:*

Quando utilizamos métodos genéricos, podemos utilizá-lo com qualquer tipo de dado e só ficamos sabendo qual tipo está sendo passado, quando estamos executando o programa.
Crie uma classe estática chamada ServicoImpressao e um método estático genérico com a assinatura:
* public static string ImprimeValorETipo< T > (T valor);
  
Esse método deverá receber um valor, que seja do tipo int, string ou double.
Depois ele deverá retornar uma string com o nome do tipo desse valor e o próprio valor.

Exemplos:

* Entrada -> 15 Saída -> "Int: 15"

* Entrada -> "Teste" Saída -> "String: Teste"

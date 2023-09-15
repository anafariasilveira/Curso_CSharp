[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/ZnrTZDyp)
﻿# Exercício 1
Crie uma hierarquia de classes para representar os diferentes tipos de funcionários de um escritório que tem os seguintes cargos: *gerente*, *assistente*, *vendedor*.  
Escreva uma classe base abstrata chamada `Funcionario` que declara um método abstrato
```csharp
double calculaSalario()
```
Esta classe também deve definir os seguintes atributos: `Nome` (*string*), `Matricula` (*string*) e `SalarioBase` (*double*).  
Use **encapsulamento** e forneça um construtor que receba os valores correspondentes a serem armazenados nos respectivos atributos. Esta classe abstrata deverá ser estendida pelas outras classes representativas dos tipos de funcionários, portanto devem ser escritas as classes `Gerente`, `Assistente` e `Vendedor`. Em cada classe deve-se sobrescrever o método `calculaSalario` de forma que cálculo do salário é feito assim:   
> O gerente recebe duas vezes o SalarioBase;  
> O assistente recebe o SalarioBase; e  
> O vendedor recebe o SalarioBase mais uma comissão de 10% do SalarioBase.   

# Exercício 2
Utilizando tipos genéricos em C#, podemos criar métodos onde, independentemente do tipo que for passado por parâmetro, podemos realizar qualquer tipo de manipulação desses dados.

Crie uma classe estática chamada `MinhaLista` e um método genérico com a assinatura:
```csharp
public static List<T> RetornaListaOrdenada<T>(T[] values)
```
Este método deve receber um *array* de valores de um determinado tipo `T` e deve retornar uma lista (*List*) de elementos do tipo `T` ordenados em **ordem ascendente**.

**Exemplos:**
Entrada → string["maçã","banana","uva","pera"]  
Saída → List{ "banana", "maçã", "pera", "uva" }  

Entrada → int[9, 4, 11, 1]  
Saída → List{ 1, 4, 9, 11 }  

# Exercício 3
Crie uma classe estática chamada `Reflections` e nessa classe crie um método estático com o nome de `RetornaMetodos`. Este método receberá um objeto (tipo *object*) e retornará uma lista de *strings* com os nomes dos métodos públicos pertencentes a esse objeto.

# Exercício 4
Refatore a classe abaixo para respeitar os princípios do SOLID.  
Adicione as classes e interfaces necessárias.  

```csharp
public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public string AdicionarCliente()
    {
        if (!Email.Contains("@"))
            return "Cliente com e-mail inválido";

        if (CPF.Length != 11)
            return "Cliente com CPF inválido";


        string connectionString = "MinhaConnectionString";
        string commandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF) VALUES (@nome, @email, @cpf))";

        var parameters = new Dictionary<string, string>();
        parameters.Add("nome", Nome);
        parameters.Add("email", Email);
        parameters.Add("cpf", CPF);

        //Abrindo conexão e gravar na base...

        var mail = "empresa@empresa.com";
        var assunto = "Bem Vindo.";
        var corpo = "Parabéns! Você está cadastrado.";
        
        //Enviando email...

        return "Cliente cadastrado com sucesso!";
    }
}
```
# Exercício 5
Imagine que você está desenvolvendo um sistema de desconto para um site de comércio eletrônico. Atualmente, você tem uma classe chamada `CalculadoraDesconto` que calcula descontos com base no tipo de cliente e no valor total da compra.

```csharp
public class CalculadoraDesconto
{
    public decimal CalcularDesconto(decimal valorTotal, string tipoCliente)
    {
        if (tipoCliente == "novo")
        {
            return valorTotal * 0.1;
        }
        else if (tipoCliente = "premium")
        {
            return valorTotal * 0.2;
        }
        else
            return 0;
    }
}
```
Adicione um novo tipo de cliente, como "VIP", sem modificar a classe CalculadoraDesconto

# Exercício 6
O que significa o Princípio da Responsabilidade Única?  
Descreva com suas palavras a relação entre a violação deste princípio e o acoplamento “ruim”.  

# Exercício 7
Quando usamos, por exemplo, herança de classes para adicionar comportamentos ao sistema sem que para isso tenhamos que alterar a classe estendida, qual dos cinco princípios SOLID estamos respeitando?

# Exercício 8
Qual a relação entre o Princípio da Substituição de Liskov e Polimorfismo?

# Exercício 9
Qual a relação entre o Princípio da Inversão de Dependência e Injeção de Dependência?

# Exercício 10
Classifique as afirmações a seguir como Verdadeiras ou Falsas.  

Uma classe abstrata pode ser instanciada.  
( ) Verdadeiro  
( ) Falso  

Uma classe abstrata pode ter método não abstratos.  
( ) Verdadeiro  
( ) Falso  

Uma classe derivada da classe abstrata obrigatoriamente deve implementar os métodos abstratos.  
( ) Verdadeiro  
( ) Falso  

A interface é um tipo de herança, ou seja, os objetos instanciados de uma interface são uma interface.  
( ) Verdadeiro  
( ) Falso  

Os contratos da interface não são obrigatórios de implementação.  
( ) Verdadeiro  
( ) Falso  

Um dos principais benefícios do uso de interfaces é que elas permitem testes e manutenção de código mais fáceis  
( ) Verdadeiro  
( ) Falso  

Outra vantagem do uso de interfaces é que elas promovem um acoplamento fraco entre classes  
( ) Verdadeiro  
( ) Falso  

A utilização de Reflection só traz benefícios para o código, pois ajuda a deixá-los mais rápido.  
( ) Verdadeiro  
( ) Falso  

É possível instanciar objetos em tempo de execução com Reflection  
( ) Verdadeiro  
( ) Falso  

O Generic possibilita uma versatilidade nos tipos, e ainda garante um tipagem segura  
( ) Verdadeiro  
( ) Falso  

Generics é utilizado para escrita de códigos reutilizáveis.  
( ) Verdadeiro  
( ) Falso  
# Lista de exercícios - Aula 01 💡

### *Exercício 01:*

Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas. Elas podem conter propriedades e métodos abstratos ou não abstratos, 
mas não podem ser instanciadas e podem forçar novas implementações de métodos virtuais.
Nesse exercício, você deverá implementar uma classe abstrata com o nome EsporteBase que será a base para outras classes. 
Essa classe deverá conter os seguintes métodos e propriedades abstratas:

* Propriedades:
    - QuantidadeJogadoresPorTime
    - TempoDeJogoEmMinutos  

* Métodos:
   - Iniciar
   - Finalizar
   - ExibirDescricao
     
Implemente uma segunda classe que irá herdar de EsporteBase, chamada Futebol. Essa classe deverá implementar as propriedade e métodos da classe base.

Crie um construtor para essa classe definindo as propriedades:
* QuantidadeJogadoresPorTime = 11
* TempoDeJogoEmMinutos = 90
  
Os métodos Iniciar e Finalizar, devem retornar as frases "O jogo foi iniciado" e "O jogo foi finalizado", respectivamente.

O método ExibirDescricao deverá retornar a frase "O futebol é um esporte praticado por X jogadores em cada time durante Y minutos", 
onde as informações X e Y devem ser os valores das propriedades preenchidas no construtor.

### *Exercício 02:*

Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

O código a seguir possui um ou mais erros que não permitem sua compilação. Identifique e reescreva o código para corrigir o problema.

> public abstract class Funcionario  { public abstract void getBonificacao(); } 

> public abstract class Secretaria { }

> public class SecretariaAdministrativa : Secretaria { public override void getBonificacao() { } }

> public class SecretariaAgencia : Secretaria { public override void getBonificacao() { } }

> public class Presidente : Funcionario { public override void getBonificacao() { } }

> public class Gerente : Funcionario { public void getBonificacao() { } }

> public class Diretor : Gerente { }

### *Exercício 04:*

Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

Elas podem conter propriedades e métodos abstratos ou não abstratos, mas não podem ser instanciadas e podem forçar novas implementações de métodos virtuais.

Crie uma classe abstrata chamada Figura. Nessa classe, nós teremos:
* Uma propriedade abstrata cor do tipo string
* Um método abstrato double area()

Em seguida, vamos criar a classe Retangulo que vai herdar a classe Figura e declarar dois atributos nela:
* double (lado1 e lado2).
  
Vamos também sobrescrever o método double area(), onde colocaremos um return com a função:
* lado 1 * lado 2, para obtermos a área.

Vamos criar uma classe Triangulo que vai herdar a classe Figura com os atributos base e altura e um método:
* double area(), que retorna base * altura.

Para finalizar, vamos criar uma classe estática chamada Teste com um método estático chamado DetalhesFigura que receberá um objeto do tipo Figura e retornará as informações sobre o objeto.

Exemplo:
* Retangulo retangulo = new Retangulo();
* retangulo.cor = "Azul";
* retangulo.lado1 = 3.5;
* retangulo.lado2 = 2;
Teste.DetalhesFigura(retangulo);

//"Cor da figura: Azul - Área da figura:

### *Exercício 06:*

Classes abstratas são úteis para implementar comportamentos comuns a classes derivadas.

Escreva uma classe abstrata chamada CartaoWeb. 
Essa classe representa todos os tipos de cartões virtuais e conterá apenas um atributo: 
* Destinatario (string)
 
Nessa classe você deverá também declarar o método:
* public abstract void ShowMessage().
  
Crie classes filhas da classe CartaoWeb: 
* DiaDosNamorados
* Natal
* Aniversario

Cada uma dessas classes deve conter um método construtor que receba o nome do destinatário do cartão. 
Cada classe também deve implementar o método ShowMessage(), mostrando uma mensagem ao usuário com seu nome e que seja específica para a data 
comemorativa do cartão.

Exemplo:
* "Feliz Dia dos Namorados, José!"
* "Feliz Natal, Maria!"
* "Feliz Aniversário, João!"

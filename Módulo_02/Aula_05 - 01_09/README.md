# Exercício - Aula 05💡

### *Exercício Aula:*

Crie um projeto Cinema e crie uma classe Filme com:
* Titulo
* Ano
* Duracao

Crie uma classe Sala com:
* quantidadeCadeiras
* Numero
  
Crie uma classe Sessao com:
* private Filme
* private Sala
* private DataHora
  
No construtor da Exibicao receba a data e a sala // Injeção de dependencia via construtor
Crie um método para receber o Filme

### *Exercício biblioteca:*

Imagine um sistema de gerenciamento de uma biblioteca. Neste sistema, você deve usar classes abstratas e interfaces para modelar diferentes tipos de itens da biblioteca, como livros, revistas e mídias digitais (por exemplo, e-books).

1. Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

2. Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

3. Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

4. Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido, enquanto uma mídia digital pode ser emprestada indefinidamente.

5. Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

6. Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca".

### *Observações:*  ⏳
Existe uma classe chamada MenuEmprestar. Minha intenção era fazer com que o usuário escolhesse o livro desejado, sem que fosse pré definido por mim. Porém, encontrei dificuldaes em realizar essa opção, então fiz apenas o proposto pelo exercício que era "emprestar" e "devolver" itens através da biblioteca.

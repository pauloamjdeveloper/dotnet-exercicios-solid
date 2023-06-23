<h1 align="center">Exercícios SOLID</h1>

## :computer: Projeto

Projeto console application para implementação de exercícios utilizando os princípios do SOLID.

## :blue_book: Lista de Exercícios

<hr>

### :book: [Exercício 1](https://github.com/pauloamjdeveloper/dotnet-exercicios-solid/tree/master/src/01-Exercicio) 

### **Cenário**
Nessa aplicação tem a classe concreta `Cliente` que representa um modelo de domínio e possui as propriedadees: `Nome`, `Pais` e `Email` e um método estático `ObtendoListaDeClientes()` que retorna uma lista de clientes.

A aplicação possui também uma classe chamada `LocalizaCliente` que permite localizar o cliente pelo nome e pelo pais, para isso esta classe utiliza os métodos: `PesquisarPorPais(string pais) e PesquisarPorNome(string nome)`.

Após algum tempo foi implementado a funcionalidade para exportar os dados dos clientes no formato `CSV(Comma Separated Values)`, isso foi feito incluindo o método `ExportarArquivo()` na classe `LocalizaCliente`.

### **Solução**
Antes houve a violação do `princípio da responsabilidade única` na classe `LocalizaCliente` que tinha duas responsabilidades, caso haja uma necessidade de exportar os dados para outros formatos como `XML` ou `PDF` vai ser necessário alterar a classe `LocalizaCleinte`, qualquer modificação nessa classe também vai exigir testes para garantir que as alterações não afetem a aplicação.

Na solução foi criada a classe `ExportarDados` e movendo o método `ExportarArquivo(List<Cliente> dados)` para esta classe.

Dessa forma é aplicado o uso do `SRP — Single Responsibility Principle`, onde as classes `LocalizaCliente` e `ExportarDados` ficam com uma única responsabilidade.

<hr>

### :book: [Exercício 2](https://github.com/pauloamjdeveloper/dotnet-exercicios-solid/tree/master/src/02-Exercicio)

### **Cenário**

Em um hipotético sistema de `Vendas` temos uma classe `Pedido` que entre outras tarefas faz a inclusão do pedido usando o método `AdicionarPedido()` no qual é feito o registro no console da inclusão do pedido e das ocorrências de erros usando a classe `ConsoleLogger`, o sistema também deverá implementar o registro de log em arquivo de texto além do console.

### **Solução**

A classe `Pedido` fazia uso de um forte acoplamento onde tinha a criação de uma instância da classe `ConsoleLogger` para fazer o registro do log no console, uma solução proposta para esse problema foi a criação da interface `ILogger` removendo essa dependência.

Foi criada a classe `FileLogger` para receber uma implementação da interface `ILogger`, nesta classe foi definido um caminho para onde o arquivo de log será salvo, fazendo com que a classe `Pedido` tenha os dados registrados nesse arquivo.

Com isso foi aplicado o uso do `DIP — Dependency Inversion Principle`, dessa forma foi utilizado o padrão da injeção de dependência para definir o uso da inversão da dependência.

### :book: Exercício 3

### **Cenário**

No desenvolvimento de uma calculadora on-line de impostos os usuários podem visitar uma página web e especificar suas receitas, deduções e calcular o imposto a pagar.

Para isso foi criada a classe `CalcularImposto` e definiu o método `Calcular()` que usa como parâmetros `Valor`, `Dedução` e o `Pais` do usuário, no qual para cada pais existe uma regra para calcular o imposto.

O método `Calcular()` determina o valor do imposto subtraindo o valor da renda das deduções totais obtendo o valorBase para o cálculo, conforme o pais do usuário é selecionado, a regra para calcular o imposto é retornado na variável valorImposto.

## :wrench: Recursos Utilizados

- [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)

## :floppy_disk: Clonar Repositório

```git clone https://github.com/pauloamjdeveloper/dotnet-exercicios-solid.git```

## Author
:boy: [Paulo Alves](https://github.com/pauloamjdeveloper)

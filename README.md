<h1 align="center">Exercícios SOLID</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 6" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## :computer: Projeto

Repositório com implementações de uma lista de exercícios utilizando boas práticas e os princípios do `SOLID`, os exercícios foram propostos no curso [C# - Aplicando Princípios SOLID na prática](https://www.udemy.com/course/c-aplicando-principios-solid-na-pratica/).  

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

### :book: [Exercício 3](https://github.com/pauloamjdeveloper/dotnet-exercicios-solid/tree/master/src/03-Exercicio)

### **Cenário**

No desenvolvimento de uma calculadora on-line de impostos os usuários podem visitar uma página web e especificar suas receitas, deduções e calcular o imposto a pagar.

Para isso foi criada a classe `CalcularImposto` e definiu o método `Calcular()` que usa como parâmetros `Valor`, `Dedução` e o `Pais` do usuário, no qual para cada pais existe uma regra para calcular o imposto.

O método `Calcular()` determina o valor do imposto subtraindo o valor da renda das deduções totais obtendo o valorBase para o cálculo, conforme o pais do usuário é selecionado, a regra para calcular o imposto é retornado na variável valorImposto.

### **Solução**

Houve uma violação do princípio aberto/fechado na classe `CalcularImposto`, a lógica implementada na classe usa um bloco `if/else` causando um forte acoplamento,
e a inclusão de novos países no cálculo do imposto vai ter que ser feita alterando a classe existente, dessa forma a classe não está fechada para alteração e nem pode ser estendida.

Para resolver o problema foi criada uma interface `ICalcularImpostoPais` onde são definidas as propriedade da renda e da dedução e o método `CalcularValorImposto()`
que deverá ser implementado por classes concretas para o cálculo do imposto para cada pais, com isso é feito o uso do princípio `OCP - Open-Closed Principle`.

<hr>

### :book: [Exercício 4](https://github.com/pauloamjdeveloper/dotnet-exercicios-solid/tree/master/src/04-Exercicio)

Uma loja pretende aplicar uma política de descontos no preço dos seus produtos bem agressiva, onde cada produto poderá de acordo com as datas especiais do calendário
(dia das mães, dia dos pais, dia das crianças, páscoa, natal etc...) ter um preço promocional, neste cenário teríamos para cada data um tipo de desconto diferente que deverá ser implementado de forma separada.

### **Solução**

Para resolver esse problema foi criada a classe abstrata `Produto` para servir como base dos produtos definindo as propriedades `Nome` e `Preço`, houve a adição das classes `Perfume` e `Celular` para representação dos produtos recebendo a implementação da classe `Produto`.

Nesse exercício foi feito uso dos principios `SRP`, `OCP`, `DIP`e `ISP - Interface Segregation Principle`, foi adicionada a interface `IPromocao` com o método `Desconto()`, essa interface foi implementada em cada classe concreta destinada a uma data comemorativa com o objetivo de aplicar descontos especificos para cada uma dessas datas.

<hr>

### :book: [Exercício 5](https://github.com/pauloamjdeveloper/dotnet-exercicios-solid/tree/master/src/05-Exercicio)

### **Cenário**

Em um sistema voltado a uma pizzaria é utilizada a classe `Pizzaria` que é responsável por informações destinadas a criação de pizzas usando o método `CriarPizza()`,
no qual recebe uma `string` para indicar o tipo da pizza que deverá ser criado.

Nesse sistema foi identificado problemas como `Forte Acoplamento`, as violações do `DRY - Don’t Repeat Yourself`, `DIP` e o `OCP` na classe `Pizzaria`.

### **Solução**

Foi criada a classe abstrata `Pizza` para representar uma classe base que recebe a propriedade `Nome`, um construtor para a inicialização desta propriedade e os métodos `AssarPizza()` e `DeliveryPizza()`, essa classe `Pizza` teve implementações feitas nas classes concretas `PizzaMussarela` e `PizzaCalabresa` que são responsáveis pelo tipo da pizza escolhida.

A classe `PizzaFactory` foi adicionada com o proposito de encapsular o objeto responsável pela criação das pizzas usando o método `CriarPizza(string tipo)`, isso permite a adição de novas classes para a criação das pizzas na medida que o projeto for crescendo, a lógica voltada para a criação das pizzas na classe `Pizza` passa a ser utilizada na classe `PizzaFactory` desacoplando o código.

## :white_check_mark: Decisões Técnicas

Procurei seguir com as mesmas ideias que foram apresentadas durante exemplos no curso, os exercícios respondidos são apenas simulações para o aprendizado dos princípios do `SOLID`.

## ✔️ Recursos Utilizados

- ``.NET 6.0``
- ``Console.application``
- ``C#``

## :floppy_disk: Clonar Repositório

```bash
git clone https://github.com/pauloamjdeveloper/dotnet-exercicios-solid.git
```

## :boy: Author

<a href="https://github.com/pauloamjdeveloper"><img src="https://avatars.githubusercontent.com/u/137198048?v=4" width=70></a>
[Paulo Alves](https://github.com/pauloamjdeveloper)

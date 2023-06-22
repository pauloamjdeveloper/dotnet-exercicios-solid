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

## :wrench: Recursos Utilizados

- [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)

## :floppy_disk: Clonar Repositório

```git clone https://github.com/pauloamjdeveloper/dotnet-exercicios-solid.git```

## Author
:boy: [Paulo Alves](https://github.com/pauloamjdeveloper)

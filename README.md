# DIO - Programação Orientada a Objeto com C#

Repositório criado para registrar os conteúdos teóricos e arquivar os arquivos dos desafios proposto. - Curso POO da DIO.

## Tabela de conteúdos

<!--ts-->

- [O que é a POO?](#O-que-é-a-POO?)
- [Tipos de Paradigmas](#Tipos-de-Paradigmas)
- [Abstração](#Abstração)
- [Encapsulamento](#Encapsulamento)
- [Herança](#Herança)
- [Polimorfismo](#Polimorfismo)
- [Classe Abstrata](#Classe-Abstrata)
- [Classe Selada](#Classe-Selada)
- [Classe Object](#Class-Object)
- [Interfaces](#Interfaces)
- [Arquivos](#Arquivos)
- [Construtores](#Construtores)
- [Getters e Setters](#Getters-e-Setters)
- [Modificadores](#Modificadores)
- [Delegates](#Delegates)
- [Eventos](#Eventos)
- [Arrays](#Arrays)
- [Links Úteis](#Links-Úteis)
- [Autor](#Autor)

<!--te-->

## O que é a POO?

A POO é um paradigma de programção, ou seja, corresponde a uma técnica de programção para um fim específico. Dentro desta técnica, exitem quatro pilares:

- Abstração
- Encapsulamento
- Herança
- Polimorfismo

O principal conceito da POO são classes e objetos!

## Tipos de Paradigmas

Paradigma de programação é diferente dce linguagem de programação. Uma linguagem de programação implementa um ou mais paradigmas. Um paradigma nada mais é do que um modelo de técnicas, estruturas e formas de solucionar um problema.

- Programação orientada a objetos
- Programação estruturada
- Programação imperativa
- Programação procedural
- Programação orientada a eventos
- Programação lógica
  e por aí vai...

## Abstração

Abstrair um objeto do mundo real para um contexto específico, considerando apenas os atributos importantes.

```
class pessoa
{
  string nome;
  int idade;

  public void apresentar(){}
}
```

## Encapsulamento

O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades. Serve para ocultar seu comportamento e expor somente o necessário.

```
class Retangulo
{
  double comprimento;
  double largura;

  public void DefinirMedidas(double, double){}
}
```

## Herança

A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes. Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.

```
class Pessoa
{
  string nome;
  int idade;
  public void apresentar() {}
}

class Aluno: Pessoa
{
  double nota;
}

class Professor: Pessoa
{
  double salario;
}
```

## Polimorfismo

O polimorfismo vem do grego e significa "muitas formas". Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportem de maneira diferente e ter sua própria implementação.

Polimorfismo em tempo de compilação (Overload/Early Binding)

```
namespace ExemploPOO.Models
{
  public class CALCULADORA
  {
    public int Somar(int num1, int num2)
    {
      return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
      return num1 + num2 + num3;
    }
  }
}
```

Polimorfismo em tempo de execução (Override/Late Binding)

```
namespace ExemploPOO.Models
{
  public class Pessoa{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Documento { get; set; }
    public virtual void Apresentar()
    {
      System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }
  }

  public class Aluno : Pessoa
  {
    public int Nota { get; set; }
    public override void Apresentar()
    {
      System.Console.WriteLine($"Olá, meu nome é {Nome}. Sou um aluno de nota {Nota}.");
    }
  }
}
```

## Classe Abstrata

Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada. Você pode implementar métodos ou deixa-los a cargo de quem herdar.

```
public <<abstract>> Conta
{
  double saldo;
  public void <<abstract>> Creditar() {}
}

public Corrente
{
  double tarifa;
  public void Creditar() {}
}
```

## Classe Selada

Uma classe selada tem como objetivo de impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada. Também existem métodos e propriedades seladas.

```
public Pessoa
{
  string nome;
  int idade;
  public void apresentar() {}
}
▼
public <<sealed>> Professor
{
  double salario;
  public void apresentar() {}
}
X
public Diretor
{
  //não permitido
}
```

## Classe Object

A classe System.Object é a mãe de todas as classes na hierarquia do .NET

Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

## Interfaces

Uma interface é um contrato que pode ser implementado por uma classe. É como se fosse uma clsse abstrata, podendo definir métodos abstratos para serem implementados. Assim como uma classe abstrata, uma interface não pode ser instanciada.

```
public <<interface>> ICalculadora {
  + somar() + subtrair() + multiplicar() + dividir()
} ---->
public CalculadoraComum {
  + somar() + subtrair() + multiplicar() + dividir()
}
public CalculadoraCientifica {
  + somar() + subtrair() + multiplicar() + dividir()
}
```

## Arquivos

O C# nos apresenta algumas classes estáticas que facilitam o trabalho com arquivos, dentre elas:

- File
- Directory
- Path

## Construtores

Um construtor é um método especial, que contém o mesmo nome do seu tipo classe, e tem o objetivo de definir valores padrão, limitar uma instância e facilitar a instanciação de um objeto.

- Um construtor não possui um retorno.
- Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe.
- Uma classe pode ter mais de um construtor.

```
public class Pessoa
{
  private string nome;
  public Pessoa()       // Construtor 1
  {

  }
  public Pessoa(string nome)  // Construtor 2
  {
    this.nome = nome;
  }
}
static void Main(string[] args)
{
  Pessoa p1 = new Pessoa();         // Chamando os construtores
  Pessoa p2 = new Pessoa("Sergio");
}
```

## Getters e Setters

O Get e Set serve para que você possa atribuir um valor em uma variável de maneira controlada e com validações.

```
namespace ExemploConstrutores.Models
{
  public class Data
  {
    private int mes;      // Variável
    public int GetMes()   // Get
    {
        return this.mes;
    }
    public void SetMes(int mes) // Set
    {
      if (mes > 0 && mes <= 12)
      {
        this.mes = mes;
      }
    }
  }
}
```

## Modificadores

#### Readonly

O modificador readonly (somente leitura) bloqueia um campo contra alterações que não sejam em sua inicialização ou pelo próprio construtor.

```
public class Pessoa
{
  private readonly string nome = "Sergio";
  private readonly string sobrenome;

  public Pessoa(string nome, string sobrenome)
  {
    this.nome = nome;
    this.sobrenome = sobrenome;
  }
  public void AlterarNome()
  {
    this.nome = "Nome Alterado"; //expressão com erro
  }
}
```

#### Constante

Uma constante representa um valor que somente pode ser atribuído no momento de sua inicialização, e não pode ser modificado posteriormente.

```
static void Main(string[] args)
{
  const double pi = 3.14;
  System.Console.WriteLine(pi);

  pi = 0;   // expressão com erro
}
```

## Delegates

Um delegate é uma maneira de passar um método como referência, podendo ser usdo como um callback, aceitando qualquer método que contenha a mesma assinatura.

```
public class Calculadora
{
  public static void Somar(int num1, int num2)
  {
    System.Console.WriteLine($"Adição: {num1 + num2}");
  }
  public static void Subtrari(int num1, int num2)
  {
    System.Console.WriteLine($"Subtração: {num1 - num2}");
  }
}

public delegate void operacao(int x, int y);

static void Main(string[] args)
{
  operacao op = Calculadora.Somar;
  op.Invoke(10, 10);
}
```

## Eventos

Eventos é um mecanismo de comunicação entre objetos, onde existe um publisher, que realiza o evento e o subscriber, que se inscreve em um evento.

```
public class Calculadora
{
  // Delegate
  public delegate void DelegateCalculadora();

  // Evento
  public static event DelegateCalculadora EventoCalculadora;

  public static void Somar(int x, int y)
  {
    if (EventoCalculadora != null)
    {
      System.Console.WriteLine($"Adição: {x + y}");
    } else {
      System.Console.WriteLine("Nenhum inscrito");
    }
  }
}
```

## Arrays

O array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.

- int[] array = new int[4];
- int[] array = new int[]{42,75,74,61};
- string[] nomes = {"Jan", "Fev"};

Exemplo Array:
int[] array = new int[]{42,75,74,61};
array[0] = 42; // Índice: é a posição de um determinado valor de um array, sempre começando com zero.

Exemplo Array Multidimensional:
O array pode possuir mais de uma dimensão
int[,] array = new int[4,2];
4 = Número de linhas
2 = Número de colunas

## Links Úteis

- [Programação Orientada a Objetos C#](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)
- [Paradigmas de Programação](https://en.wikipedia.org/wiki/Comparison_of_multi-paradigm_programming_languages)
- [Classes e Estruturas](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Classe Selada](https://dotnettutorials.net/lesson/sealed-class-methods-csharp/)
- [Leornardo Buta](https://github.com/leonardo-buta)
- [Delegates e Eventos](https://www.c-sharpcorner.com/UploadFile/84c85b/delegates-and-events-C-Sharp-net/)
- [Tipos de Construtores](https://github.com/leonardo-buta/curso-tipos-de-construtores-dio)

## Autor 😎

<a href="https://app.rocketseat.com.br/me/sergio-silva-lima-1567192156">
 <img style="border-radius: 50%;" src="https://avatars1.githubusercontent.com/u/48762187?v=4" width="100px;" alt="Sergio SLima"/>
 <br />
 <sub><b>Sergio Silva Lima</b></sub></a> <a href="https://app.rocketseat.com.br/me/sergio-silva-lima-1567192156" title="Rocketseat">🚀
</a>

Desenvolvido por:
Sergio Lima 👋🏽
Entre em contato!

[![Github Badge](https://img.shields.io/badge/-Github-000?style=flat-square&logo=Github&logoColor=white&link=https://github.com/fagnerpsantos)](https://github.com/sergio-slima)
[![Linkedin Badge](https://img.shields.io/badge/-LinkedIn-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fagnerpsantos/)](https://www.linkedin.com/in/sergio-silva-lima-b99237140/)
[![Instagram Badge](https://img.shields.io/badge/-Instagram-red?style=flat-square&labelColor=red&logo=instagram&logoColor=white&link=https://www.instagram.com/sergio_silva_/)](https://www.instagram.com/sergio_silva_/)

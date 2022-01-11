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

## Links Úteis

- [Programação Orientada a Objetos C#](https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop)
- [Paradigmas de Programação](https://en.wikipedia.org/wiki/Comparison_of_multi-paradigm_programming_languages)
- [Classes e Estruturas](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Classe Selada](https://dotnettutorials.net/lesson/sealed-class-methods-csharp/)
- [Teste](Teste)

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

namespace ExemploConstrutores.Models
{
  public class Pessoa
  {
    private readonly string nome;
    private string sobrenome;

    public Pessoa()
    {
      nome = string.Empty;
      sobrenome = string.Empty;
    }

    public Pessoa(string nome, string sobrenome)
    {
      this.nome = nome;
      this.sobrenome = sobrenome;
      System.Console.WriteLine("Construtor classe Pessoa");
    }

    public string Sobrenome { get => sobrenome; set => sobrenome = value; }
    public string Sobrenome1 { get => sobrenome; set => sobrenome = value; }

    public void Apresentar()
    {
      System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
    }

    public override bool Equals(object? obj)
    {
      return obj is Pessoa pessoa &&
             sobrenome == pessoa.sobrenome;
    }
  }
}
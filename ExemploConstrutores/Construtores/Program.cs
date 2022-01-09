using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {
    public delegate void Operacao(int x, int y);
    static void Main(string[] args)
    {
      Matematica m = new Matematica(10, 20);
      m.Somar();

      // CLASS CALCULADORA - DELEGATE
      // Operacao op = new Operacao(Calculadora.Somar);
      // op += Calculadora.Subtrair;
      // op.Invoke(10, 5);

      // MODIFICADOR CONSTANTE
      // const double pi = 3.14;
      // System.Console.WriteLine(pi);

      // CLASSE DATA
      // Data data = new Data();
      // data.setMes(5);
      // data.Mes = 13;

      // data.ApresentarMes();

      // CLASSE PESSOA
      // Log log = Log.GetInstance();
      // log.PropriedadeLog = "Teste Instancia";

      // Log log2 = Log.GetInstance();
      // System.Console.WriteLine(log2.PropriedadeLog);

      // CLASSE ALUNO
      // Aluno p1 = new Aluno("Sergio", "Lima", "Matematica");
      // p1.Apresentar();
    }
  }
}
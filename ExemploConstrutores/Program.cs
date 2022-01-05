using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {
    static void Main(string[] args)
    {
      Data data = new Data();
      data.setMes(5);
      data.Mes = 13;

      data.ApresentarMes();

      // Log log = Log.GetInstance();
      // log.PropriedadeLog = "Teste Instancia";

      // Log log2 = Log.GetInstance();
      // System.Console.WriteLine(log2.PropriedadeLog);

      // Aluno p1 = new Aluno("Sergio", "Lima", "Matematica");
      // p1.Apresentar();
    }
  }
}
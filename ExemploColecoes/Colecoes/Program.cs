// See https://aka.ms/new-console-template for more information
using System;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      // ARRAY BUBLLE SORT
      OperacoesArray op = new OperacoesArray();
      int[] array = new int[5] { 6, 3, 8, 1, 9 };
      int[] arrayCopia = new int[10];
      string[] arrayString = op.CoverterArrayForString(array);

      int valorProcurado = 8;

      System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
      op.RedimensionarArray(ref array, array.Length * 2);
      System.Console.WriteLine($"Capacidade array redimencionado: {array.Length}");

      int indice = op.ObterIndice(array, valorProcurado);
      if (indice > -1)
      {
        System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
      }

      int valorAchado = op.BuscarValor(array, valorProcurado);
      if (valorAchado > 0)
      {
        System.Console.WriteLine("Encontrei o valor");
      }
      else
      {
        System.Console.WriteLine("Não encontrei o valor");
      }

      // bool maiorQue = op.MaiorQue(array, valorProcurado);
      // if (maiorQue)
      // {
      //   System.Console.WriteLine("Valores maior que {0}", valorProcurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("Existe valores menores que {0}", valorProcurado);
      // }

      // bool existe = op.Existe(array, valorProcurado);
      // if (existe)
      // {
      //   System.Console.WriteLine("Encontrei o valor: (0)", valorProcurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("Não encontrei o valor: (0)", valorProcurado);
      // }

      // System.Console.WriteLine("Array original:");
      // op.ImprimirArray(array);

      // op.OrdernarBubbleSort(ref array);
      //op.Ordenar(ref array);      

      // System.Console.WriteLine("Array ordenado:");
      // op.ImprimirArray(array);

      // System.Console.WriteLine("Array antes da copia:");
      // op.ImprimirArray(arrayCopia);

      // op.Copiar(ref array, ref arrayCopia);
      // System.Console.WriteLine("Array após a cópia:");
      // op.ImprimirArray(arrayCopia);

      // ARRAY MATRIZ
      // int[,] matriz = new int[4, 2]
      // {
      //   {8,8},
      //   {10,20},
      //   {50,100},
      //   {90,200}
      // };

      // for (int i = 0; i < matriz.GetLength(0); i++)
      // {
      //   for (int j = 0; j < matriz.GetLength(1); j++)
      //   {
      //     System.Console.WriteLine(matriz[i, j]);
      //   }
      // }

      // ARRAY INT
      // int[] arrayInteiros = new int[3];

      // arrayInteiros[0] = 10;
      // arrayInteiros[1] = 20;
      // arrayInteiros[2] = int.Parse("30"); //converter string para inteiro

      // System.Console.WriteLine("Array For");
      // for (int i = 0; i < arrayInteiros.Length; i++)
      // {
      //   System.Console.WriteLine(arrayInteiros[i]);
      // }

      // System.Console.WriteLine("Array Foreach");
      // foreach (int item in arrayInteiros)
      // {
      //   System.Console.WriteLine(item);
      // }
    }
  }
}
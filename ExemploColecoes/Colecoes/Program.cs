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

      System.Console.WriteLine("Array original:");
      op.ImprimirArray(array);

      op.OrdernarBubbleSort(ref array);
      System.Console.WriteLine("Array ordenado:");
      op.ImprimirArray(array);

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
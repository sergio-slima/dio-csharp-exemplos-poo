﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matriz = new int[4, 2]
      {
        {8,8},
        {10,20},
        {50,100},
        {90,200}
      };

      for (int i = 0; i < matriz.GetLength(0); i++)
      {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
          System.Console.WriteLine(matriz[i, j]);
        }
      }

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
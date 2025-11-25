// See https://aka.ms/new-console-template for more information
/*Faça um programa que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos
dólares ela pode comprar. Considere US$1,00 = R$5,15. Exiba os valores com formatação de moeda
(ou seja, especificador do .ToString → “C” e na cultura correspondente: pt-BR para Reais e en-US para
Dólar).*/


using System;
using System.Globalization;

namespace Questao00Lista2;
class Questao00Lista2
{
    public static void Main (string[] args);

  //Valores Iniciais para as variáveis
    decimal ValorCarteira = 0;
    decimal ValorDolar = Convert.ToDecimal("5,15");
    decimal QtdeDolares = 0;

while (true)
    // Perguntando ao usuário o valor em dinheiro.
    Console.WriteLine("Favor informe o valor em dinheiro que há em sua carteira:");
    Console.ReadLine();
    ValorCarteira = Convert.ToDecimal(Console.ReadLine());
    ValorDolar = Convert.ToDecimal("5,15");
    QtdeDolares = ValorCarteira / ValorDolar;
  }
}
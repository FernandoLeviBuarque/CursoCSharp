/* 
 Faça um programa que pergunte a distância ue um passageiro deseja percorrer em Km. Calcule
o preço da viagem, cobrando R$0,50 por Km para viagens até 200 Km e R$0,45 para viagens mais longas, além de
uma taxa fixa de R$5,65. A formatação deve ser apresentada em moeda nacional.
 */

using System;

    // Informe a distância em Km a ser percorrida pelo passageiro
    Console.WriteLine("Favor Informar a distância em Km a ser percorrida pelo passageiro: ");
    Decimal Distancia = Convert.ToDecimal(Console.ReadLine()); // Faz a leitura da distancia já com 2 casas decimais.
    Decimal TaxaFixa = Convert.ToDecimal(5.65m);

if (Distancia <= 200)
{   // Calculo para viagens até 200km.
    Decimal Preco = Convert.ToDecimal((Distancia * 0.50m)) + TaxaFixa;
    Console.WriteLine("O Preco da Viagem é de: " + Convert.ToString(Preco));
}
else
{   // Calculo para viagens mais longas.
    Decimal Preco = (Distancia * 0.45m) + TaxaFixa;
    Console.WriteLine("O Preco da Viagem é de: " + Convert.ToString(Preco));
}
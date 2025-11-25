/*
 QUESTÃO 03: Faça um programa que pergunte a velocidade de um carro e, se ultrapassar 80km/h, 
calcule uma multa de R$5 reais por km acima do limite */

using System;

// Digitando a velocidade do carro

Console.WriteLine("Informar a Velocidade de Veiculo: ");
int Velocidade = Convert.ToInt32(Console.ReadLine());
int LimiteVel = 80;  // Atribuindo o valor do limite de velocidade

if (Velocidade > 80) // Testando se o limite foi ultrapassado.
{
    int ValordoExcesso = Velocidade - LimiteVel; // Calcula o excesso acima da velocidade máxima
    int Multa = ValordoExcesso * 5; // Calculo da Multa
    Console.Write("O Veiculo excedeu o limite de velocidade em " + ValordoExcesso + "Km/h");
    Console.Write(" e devera pagar uma multa de " + Convert.ToString(Multa) + " Reais ");
}
else
{
    Console.WriteLine("Veiculo trafegando na Velocidade permitida"); // Motorista cumpre o limite
}

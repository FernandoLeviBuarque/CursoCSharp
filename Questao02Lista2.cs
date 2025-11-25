// DESENVOLVA UM PROGRAMA EM C# QUE LEIA UM NÚMERO INTEIRO E MOSTRE SE ELE É PAR OU ÍMPAR.
using System;

class Questao02Lista2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0) // Testa se o resto da divisão por 2 é igual a zero
    {
            Console.WriteLine("O número é par.");  // Se sim, é par.
        }
        else
        {
            Console.WriteLine("O número é ímpar."); // Senão, é impar.
        }
}
    }

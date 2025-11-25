// See https://aka.ms/new-console-template for more information
/* Faça um programa que leia a largura e a altura de uma parece, calcule e mostre a área a ser pintada 
 * e a quantidade de tinta necessária sabendo que um litro pinta 0.5 m2. */

using System;
using System.Globalization;

class Questao01Lista2
{
    static void Main()    
    {
        Console.WriteLine("Digite a largura da parede");
        Decimal largura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite a altura da parede");
        Decimal altura = Convert.ToDecimal(Console.ReadLine());
        Decimal Area = largura * altura;
        Decimal QtdeTinta = Area / 0.5m; // CORREÇÃO FEITA PELO COPILOT. Estava 0.5 antes, dando erro.
        /* DICA DO COPILOT  - Literal decimal: quando você divide por 0.5, 
         * o compilador interpreta como double. Para evitar conversões implícitas, use 0.5m.
            */
        Console.WriteLine("A area da parede é de " + Area.ToString("F2") + " metros quadrados");
        Console.WriteLine("Serão necessários " + QtdeTinta.ToString("F2") + " litros de tinta para pintar toda a parede");
    }
}


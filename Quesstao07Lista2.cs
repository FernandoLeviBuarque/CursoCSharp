/*  Crie um programa que leia o nome de um funcionário, seu salário, quantos anos
 ele trabalha na empresa e mostre seu novo salário, reajustado de acordo com a tabela 
a seguir: 
- Até 3 anos de empresa: 3% de aumento
- Entre 3 (inclusive) e menos de 10 anos: Aumento de 12.5%
- 10 Anos ou mais: aumento de 20% */

using System;

class CalculodoSalario
{
    static void Main()
    {   // Entrada de dados dos funcionários
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o salário do funcionário: ");
        double salario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite quantos anos ele trabalha na empresa: ");
        int anosEmp = Convert.ToInt32(Console.ReadLine());

        // Calculo do novo salario a partir do tempo de empresa
        if (anosEmp < 3)
        {
            salario *= 1.03;
        }
        else if (anosEmp >= 3 && anosEmp < 10)
        {
            salario *= 1.125;
        }
        else
        {
            salario *= 1.20;
        }
        // Exibição do novo salário
        Console.WriteLine($"O novo salário do funcionário {nome} é: R$ {salario:F2}"); // Formatação para 2 casas decimais (Copilot)

        Console.WriteLine(nome + " possui " + anosEmp + " anos de empresa.");
    }
}

/* Locadora de Veículos
 Tipo de carro: Popular ou Luxo
- 90 popular + 0,20 por KM se for <= 100.
- 90 popular + 0,10 por KM se for > 100.

- 150 lUXO + 0,30 por KM se for <= 200.
- 150 lUXO + 0,25 por KM se for > 200.  
 */
using System;
class Program
{
    static void Main()
    {
        // Entrada de Dados
        Console.WriteLine("Digite o modelo do carro: P - Popular ou L - Luxo : ");
        String modeloCarro = Console.ReadLine().ToUpper();

        Console.WriteLine("Digite a quantidade de KM percorridos: ");
        int QtdeKm = Convert.ToInt32(Console.ReadLine());

        if (modeloCarro == "P")

        { decimal valorTotalP;
            if (QtdeKm <= 100)
            {
                valorTotalP = 90 + 0.20m * QtdeKm;
            }
            else
            {
                valorTotalP = 90 + 0.10m * QtdeKm;
            }
            Console.WriteLine("O valor total a pagar é: " + valorTotalP);
        }

       else if (modeloCarro == "L")
        {
            decimal VtLuxo;
            if (QtdeKm <= 200)
            {
                VtLuxo = 150 + 0.30m * QtdeKm;
            }
            else
            {
                VtLuxo = 150 + 0.25m * QtdeKm;
            }
            Console.WriteLine("O valor total a pagar é: " + VtLuxo);
        }
        else if (modeloCarro != "P" && modeloCarro != "L")
        { /* SUGESTÃO DE MELHORIA FEITA PELO COPILOT.
            O CÓDIGO ANTERIOR NÃO POSSUÍA ESSA VERIFICAÇÃO, ENTÃO RESOLVI ADICIONAR.*/
            Console.WriteLine("Modelo de carro inválido!");
            /*OUTRAS MELHORIAS POSSÍVEIS DE ACORDO COM O COPILOT
             - Usar switch em vez de if/else para deixar o código mais limpo.
             - Validar se o usuário digitou um número válido para KM (int.TryParse).
             - Formatar o valor monetário com ToString("C") para mostrar como moeda.
             */

        }
    }
}
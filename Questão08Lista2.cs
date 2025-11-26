/* Crie um programa para aprovar ou não o empréstimo bancário para a compra de uma casa.
 O programa vai perguntar o valor da casa, o salário do comprador e em quantos anos ele vai
pagar. Calcule o valor da prestação mensal, sabendo ue ela não pode exceder 30% do salário
ou então o empréstimo será negado.*/

class AprovaCredito 
{
    static void Main(string[] args)
    {
        // Entrada de dados
        Console.WriteLine("Digite o valor do imovel desejado: ");
        double valorCasa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o seu salário: ");
        double salarioComprador = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o prazo para pagamento: ");
        int anosParaPagar = Convert.ToInt32(Console.ReadLine());
        double prestacaoMensal = valorCasa / (anosParaPagar * 12);
        double limitePrestacao = salarioComprador * 0.3;
        
        // Calculo do limite permitido
        if (prestacaoMensal <= limitePrestacao)
        {
            Console.WriteLine("Empréstimo concedido.");
            Console.WriteLine($"Sua prestação mensal será de: {prestacaoMensal:C2}");// Fomato do copilot
        }
        else
        {
            Console.WriteLine("Empréstimo negado.");
            Console.WriteLine($"Infelizmente, a sua prestação mensal de {prestacaoMensal:C2} excede 30% da sua renda.");
        }
    }
}
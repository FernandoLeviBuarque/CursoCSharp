// Programa para leitura de 3 notas de alunos

using System.Net.Security;

Console.WriteLine("Digite o nome do Aluno:");

var Nome = Console.ReadLine();

// Cumprimentando pelo nome

Console.Write("Olá, ");
Console.WriteLine(Nome);

//Digitando, lendo e atribuindo à nota1

Console.WriteLine("Digite a primeira nota: ");
var Nota1 = Console.ReadLine();

//Digitando, lendo e atribuindo à nota2

Console.WriteLine("Digite a segunda nota: ");
var Nota2 = Console.ReadLine();

//Digitando, lendo e atribuindo à nota3

Console.WriteLine("Digite a terceira nota: ");
var Nota3 = Console.ReadLine();

var Nota1Num = Convert.ToDouble(Nota1);
var Nota2Num = Convert.ToDouble(Nota2);
var Nota3Num = Convert.ToDouble(Nota3);

var Soma = Nota1Num + Nota2Num + Nota3Num; // Somando as 3 Notas

var Media = Soma / 3;  // Cálculo da média

//Escrevendo a média

Console.WriteLine(Nome, "A sua média foi: ");
Console.WriteLine(Media);

if (Media >= 7)
{
    Console.WriteLine("O Aluno foi aprovado!");
}
else
{
    Console.WriteLine("O Aluno foi reprovado!");
}

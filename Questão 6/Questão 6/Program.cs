//iniciando variaveis
double nota1, nota2, nota3;
int peso1 = 1, peso2 = 2, peso3 = 3;

//iniciando o programa
Console.WriteLine("Seja bem vindo!");
Console.WriteLine("Para iniciar, digite a primeira nota do aluno");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Agora, digite a segunda nota do aluno");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Por fim, digite a terceira nota do aluno");
nota3 = Convert.ToDouble(Console.ReadLine());

//calculando a media ponderada
double mediaPonderada = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);
Console.WriteLine($"A média ponderada do aluno é: {mediaPonderada}");

//verificando se o aluno foi aprovado, reprovado ou está em exame
//considerando Aprovado (Média ≥7.0) ,Recuperação(5.0≤Média < 7.0) , Reprovado(Média < 5.0)
if (mediaPonderada >= 7.0)
{
    Console.WriteLine("O aluno foi APROVADO!");
}
else if (mediaPonderada >= 5.0 && mediaPonderada < 7.0)
{
    Console.WriteLine("O aluno está de RECUPERAÇÃO!");
}
else
{
    Console.WriteLine("O aluno foi REPROVADO!");
}
Console.WriteLine("Obrigado por utilizar nosso sistema!");
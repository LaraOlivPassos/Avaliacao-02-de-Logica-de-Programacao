// iniciando a lista de nomes
LinkedList<string> nomes = new LinkedList<string>(new string[]
{ 
    "Lara", "Julia", "Maria Luisa", "Pietra", "Sofia" 
});
// Iniciando busca de nome
Console.WriteLine("Digite um nome para pesquisar:");
string nomeParaBuscar = Console.ReadLine()!;
bool encontrado = false;
foreach (string nome in nomes)
{
    if (nome.Equals(nomeParaBuscar, StringComparison.OrdinalIgnoreCase))
    {
        encontrado = true;
        break;
    }
}
if (encontrado)
{
    Console.WriteLine($"O nome {nomeParaBuscar} foi encontrado no vetor.");
}
else
{
    Console.WriteLine($"O nome {nomeParaBuscar} não está no vetor.");
}
Console.WriteLine("Pressione qualquer tecla para sair...");

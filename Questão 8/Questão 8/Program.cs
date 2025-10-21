class Program
{
    static void Main(string[] args)
    {
        int voto;
        int candidatoA = 0;
        int candidatoB = 0;
        int candidatoC = 0;
        int nulo = 0;

        Console.WriteLine("=== Sistema de Votação Simplificado ===");
        Console.WriteLine("Opções de voto:");
        Console.WriteLine("1 - Candidato A");
        Console.WriteLine("2 - Candidato B");
        Console.WriteLine("3 - Candidato C");
        Console.WriteLine("9 - Voto Nulo");
        Console.WriteLine("0 - Encerrar votação");

        do
        {
            Console.Write("Digite o seu voto: ");
            voto = int.Parse(Console.ReadLine()!);

            switch (voto)
            {
                case 1:
                    candidatoA++;
                    break;
                case 2:
                    candidatoB++;
                    break;
                case 3:
                    candidatoC++;
                    break;
                case 9:
                    nulo++;
                    break;
                case 0:
                    Console.WriteLine("Encerrando votação...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

        } while (voto != 0);

        Console.WriteLine("\nResultado da Votação\n");
        Console.WriteLine($"Candidato A: {candidatoA} voto(s)");
        Console.WriteLine($"Candidato B: {candidatoB} voto(s)");
        Console.WriteLine($"Candidato C: {candidatoC} voto(s)");
        Console.WriteLine($"Votos Nulos: {nulo}");
        Console.WriteLine();
    }
}
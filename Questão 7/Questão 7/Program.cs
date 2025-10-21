using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita os números inicial e final ao usuário
            Console.Write("Digite o número inicial:");
            int inicio = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o número final:");
            int fim = int.Parse(Console.ReadLine()!);

            Console.WriteLine();

            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine($"Tabuada do {i}:");

                for (int valorMultiplicado = 1; valorMultiplicado <= 10; valorMultiplicado++)
                {
                    Console.WriteLine($"{i} x {valorMultiplicado} = {i * valorMultiplicado}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Fim da tabuada!");
        }
    }
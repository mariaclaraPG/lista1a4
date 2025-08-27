using System;
using Biblioteca;

class atv4
{
    static int Mainum(int[] vetor)
    {
        int maior = vetor[0];
        if (vetor.Length > 0)
        {

            for (int i = 0; i < vetor.Length; i++)
            {
                if (maior < vetor[i])
                {
                    int tmp = maior;
                    maior = vetor[i];
                    vetor[i] = maior;
                }
            }

        }
        return maior;
    }
        
        static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor: \n");
            n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            BibliotecaVetor.gerarVetor(vetor);
            BibliotecaVetor.mostrarVetor(vetor);
            int maiorvt = Mainum(vetor);
            Console.WriteLine("\nMenor número: " + maiorvt);
            Console.ReadKey();
        }
    
}

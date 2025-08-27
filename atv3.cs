using System;
using Biblioteca;

class atv3
{
    static int Mennum(int[] vetor)
    {
        int menor = vetor[0];
        if (vetor.Length > 0)
        {

            for (int i = 0; i < vetor.Length; i++)
            {

                if (menor > vetor[i])
                {
                    int tmp = menor;
                    menor = vetor[i];
                    vetor[i] = menor;
                }
            }

        }
        return menor;
    }
        
        static void Main()
        {
            int n;
            Console.WriteLine("Tamanho do vetor: \n");
            n = int.Parse(Console.ReadLine());
            int[] vetor = new int[n];
            BibliotecaVetor.gerarVetor(vetor);
            BibliotecaVetor.mostrarVetor(vetor);
            int menorvt = Mennum(vetor);
            Console.WriteLine("\nMenor número: " + menorvt);
            Console.ReadKey();
        }
    
}

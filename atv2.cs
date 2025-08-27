using System;
using Biblioteca;

class atv2
{
    static int contadorImpar(int[] vetor)
    {
        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                contador++;
            }
        }
        return contador;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor: \n");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        BibliotecaVetor.gerarVetor(vetor);
        BibliotecaVetor.mostrarVetor(vetor);
        int qtdImpar = contadorImpar(vetor);
        Console.WriteLine("\nQuantidade de Ímpares: " + qtdImpar);
        Console.ReadKey();
    }
}

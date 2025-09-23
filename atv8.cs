using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using MinhaBiblioteca;

class atv8
{
   
    static void Main()
    {
        int x, y, quantidadeRaios;
        int linhas, cols, ocr=0;
        Console.WriteLine("Quantidade de linhas e colunas na area: ");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] mapa = new int[linhas, cols];
        Console.Write("Quantos raios foram anotados?: ");
        quantidadeRaios = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.Write("Cordenadas que o raio caiu: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;

            if (mapa[x, y] == '1')
            {
                ocr++;
            }
            else
            {
                ocr=ocr+0;
            }

        }
        bibliotecamatriz.mostrarMatriz(mapa);
        Console.Write("Quantos raios aparecem 2 vezes?: "+ocr);
    }
}
using System;

class atv1
{
    static void somaArray(int[] vetor){
    int resultado = 0;
    for(int i = 0; i < 10; i++){
        resultado = resultado + vetor[i];
    }
    Console.WriteLine($"A soma dos elementos do array é: {resultado}\n");
}
    static void Main()
    {
        int n;
        Console.Write("Entre com o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
          Console.WriteLine("Entre com os dados do vetor: ");
        for (int i = 0; i < meuArray.Length; i++)
        {
            Console.Write($"Array[{i}]:");
            meuArray[i] = int.Parse(Console.ReadLine());
        }
        somaArray(meuArray);

        
    }
}
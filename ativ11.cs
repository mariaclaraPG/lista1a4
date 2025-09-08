using System;

class ativ11
{
    static string decodificar(string fraseCodificada)
    {
        int n = fraseCodificada.Length;
        int pos = 0;
        char[] decodifica = new char[n];
        for (int i = 0; i < n; i++)
        {
            if (fraseCodificada[i] != 'p')
            {
                decodifica[pos] = fraseCodificada[i];
                pos++;
            }
             else if ((fraseCodificada[i + 1] == 'p' )&&(fraseCodificada[i + 2] == 'p' ))
            {
                  decodifica[pos] = fraseCodificada[i];
                pos++;
            }
           
        }
        return new string(decodifica);
    }
    static void Main()
    {
        string frase;
        Console.WriteLine("Entre com frase codificada:");
        frase = Console.ReadLine();
        Console.WriteLine("Frase decodificada: "+ decodificar(frase));
    }
}
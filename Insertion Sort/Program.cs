using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };

        Console.WriteLine("Vetor Original:");
        foreach (int item in vetor)
            Console.Write($"{item} ");

        int[] vetorOrdenado = IntArrayInsertionSort(vetor);

        Console.WriteLine("\nVetor Ordenado:");
        foreach (int item in vetorOrdenado)
            Console.Write($"{item} ");
    }

    public static int[] IntArrayInsertionSort(int[] vetor)
    {
        int n = vetor.Length;
        int i, j, chave;
        for (j = 1; j < n; j++)
        {
            chave = vetor[j];
            i = j - 1;
            while (i >= 0 && vetor[i] > chave)
            {
                vetor[i + 1] = vetor[i];
                i--;
            }
            vetor[i + 1] = chave;
        }
        return vetor;
    }
}

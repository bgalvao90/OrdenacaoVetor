using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 26, 65, 45, 73, 10, 18, 78, 93, 70, 49, 23, 22 };

        Console.WriteLine("Array Original:");
        foreach (int item in vetor)
            Console.Write($"{item} ");

        int[] arrayOrdenado = IntArrayBubbleSort(vetor);

        Console.WriteLine("\nArray Ordenado:");
        foreach (int item in arrayOrdenado)
            Console.Write($"{item} ");
    }

    public static int[] IntArrayBubbleSort(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho - 1; i++)
        {
            for (int j = 0; j < tamanho - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    int aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                }
            }
        }
        return vetor;
    }
}

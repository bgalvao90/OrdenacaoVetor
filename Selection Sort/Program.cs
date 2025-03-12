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

        int[] arrayOrdenado = IntArraySelectionSort(vetor);

        Console.WriteLine("\nArray Ordenado:");
        foreach (int item in arrayOrdenado)
            Console.Write($"{item} ");
    }

    public static int[] IntArraySelectionSort(int[] vetor)
    {
        int tamanho = vetor.Length;
        int i, j, min;
        for (i = 0; i < tamanho - 1; i++)
        {
            min = i;
            for (j = i + 1; j < tamanho; j++)
            {
                if (vetor[j] < vetor[min])
                {
                    min = j;
                }
            }
            if (i != min)
            {
                int aux = vetor[i];
                vetor[i] = vetor[min];
                vetor[min] = aux;
            }
        }
        return vetor;
    }
}

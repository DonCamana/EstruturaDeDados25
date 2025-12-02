using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Vetor original:");
        ImprimirVetor(vetor);

        MergeSort(vetor, 0, vetor.Length - 1);

        Console.WriteLine("\nVetor ordenado:");
        ImprimirVetor(vetor);
    }

    // Função principal do Merge Sort
    static void MergeSort(int[] array, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int meio = (inicio + fim) / 2;

            // Ordena a metade esquerda
            MergeSort(array, inicio, meio);

            // Ordena a metade direita
            MergeSort(array, meio + 1, fim);

            // Junta as duas metades
            Merge(array, inicio, meio, fim);
        }
    }

    // Função que combina dois subarrays ordenados
    static void Merge(int[] array, int inicio, int meio, int fim)
    {
        int tamanhoEsq = meio - inicio + 1;
        int tamanhoDir = fim - meio;

        // Arrays temporários
        int[] esquerda = new int[tamanhoEsq];
        int[] direita = new int[tamanhoDir];

        // Copia dados para os subarrays temporários
        for (int i = 0; i < tamanhoEsq; i++)
            esquerda[i] = array[inicio + i];

        for (int j = 0; j < tamanhoDir; j++)
            direita[j] = array[meio + 1 + j];

        int indiceEsq = 0, indiceDir = 0;
        int indiceFinal = inicio;

        // Intercala os arrays
        while (indiceEsq < tamanhoEsq && indiceDir < tamanhoDir)
        {
            if (esquerda[indiceEsq] <= direita[indiceDir])
            {
                array[indiceFinal] = esquerda[indiceEsq];
                indiceEsq++;
            }
            else
            {
                array[indiceFinal] = direita[indiceDir];
                indiceDir++;
            }
            indiceFinal++;
        }

        // Copia o restante do lado esquerdo (se sobrou)
        while (indiceEsq < tamanhoEsq)
        {
            array[indiceFinal] = esquerda[indiceEsq];
            indiceEsq++;
            indiceFinal++;
        }

        // Copia o restante do lado direito (se sobrou)
        while (indiceDir < tamanhoDir)
        {
            array[indiceFinal] = direita[indiceDir];
            indiceDir++;
            indiceFinal++;
        }
    }

    // Função para imprimir o vetor
    static void ImprimirVetor(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

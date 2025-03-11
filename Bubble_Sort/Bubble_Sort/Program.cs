using System;
using System.Diagnostics;

// Bubble Sort algoritmasını farklı dizi boyutlarında test eden ve geçen süreyi ölçen bir
// C# Console App kodu

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 5000, 10000 }; // Farklı dizi boyutları
        foreach (int size in sizes)
        {
            int[] array = GenerateRandomArray(size); // Rastgele dizi oluştur

            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(array);
            sw.Stop();

            Console.WriteLine($"Dizi Boyutu: {size} - Geçen Süre: {sw.ElapsedMilliseconds} ms");
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false; // Optimizasyon: Eğer değişiklik olmazsa sıralama bitmiştir
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap işlemi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break; // Eğer iç döngüde swap yapılmazsa dizimiz sıralıdır
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(1, 100000); // Rastgele 1 ile 100000 arasında sayı ekle
        }
        return arr;
    }
}

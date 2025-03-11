using System;
using System.Diagnostics;

// İlk k elemanı sıralayıp, geri kalan elemanları Insertion Sort mantığı ile işleyerek
// k. en küçük elemanı bulur.
class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10000); // Rastgele 10000 elemanlı bir dizi oluştur
        int k = 5;

        Stopwatch sw = Stopwatch.StartNew();
        int result = FindKthSmallestUsingInsertionSort(array, k);
        sw.Stop();

        Console.WriteLine($"2. Yöntem (K Elemanlı Sıralama + Insertion Mantığı) - {k}. En Küçük Eleman: {result}");
        Console.WriteLine($"Geçen Süre: {sw.ElapsedMilliseconds} ms");
    }

    static int FindKthSmallestUsingInsertionSort(int[] arr, int k)
    {
        int[] temp = new int[k]; // K elemanlık bir geçici dizi oluştur

        for (int i = 0; i < k; i++)
            temp[i] = arr[i]; // İlk k elemanı al

        Array.Sort(temp); // İlk k elemanı sırala

        for (int i = k; i < arr.Length; i++)
        {
            if (arr[i] < temp[k - 1]) // Eğer yeni eleman k. en küçüğünden küçükse
            {
                temp[k - 1] = arr[i]; // En büyük olanı değiştir
                int j = k - 1;

                // Insert işlemini yaparak küçük elemanı yerine koy
                while (j > 0 && temp[j] < temp[j - 1])
                {
                    int tempValue = temp[j];
                    temp[j] = temp[j - 1];
                    temp[j - 1] = tempValue;
                    j--;
                }
            }
        }
        return temp[k - 1]; // k. en küçük elemanı döndür
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

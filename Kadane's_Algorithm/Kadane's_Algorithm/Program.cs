using System;

// Kadane's Algorithm, verilen bir dizide en büyük toplamı veren alt diziyi (subarray) bulmak için kullanılır

class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = KadaneAlgorithm(arr);

        Console.WriteLine($"En Büyük Alt Dizi Toplamı: {maxSum}");
    }

    static int KadaneAlgorithm(int[] arr)
    {
        int maxSoFar = arr[0];  // Şu ana kadar bulunan en büyük toplam
        int maxEndingHere = arr[0]; // O anki alt dizinin toplamı

        for (int i = 1; i < arr.Length; i++)
        {
            // Eğer önceki toplam negatifse, yeni bir alt dizi başlat
            maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);

            // Şu ana kadar bulunan en büyük toplamı güncelle
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}


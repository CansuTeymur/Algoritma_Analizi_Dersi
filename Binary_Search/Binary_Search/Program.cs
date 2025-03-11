using System;

class Program
{
    static void Main()
    {
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 15, 18, 21 };
        int target = 7;

        int index = BinarySearchIterative(sortedArray, target);

        if (index != -1)
            Console.WriteLine($"Eleman {target}, {index}. indekste bulundu.");
        else
            Console.WriteLine($"Eleman {target} dizide bulunamadı.");
    }

    static int BinarySearchIterative(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; // Eleman bulundu

            if (arr[mid] < target)
                left = mid + 1; // Sağ yarıya git
            else
                right = mid - 1; // Sol yarıya git
        }

        return -1; // Eleman bulunamadı
    }
}

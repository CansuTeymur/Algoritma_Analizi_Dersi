using System;

// Bir dizi kullanarak ekleme, silme, güncelleme ve arama işlemlerini gerçekleştiren bir sınıf.
class DiziYonetici
{
    private int[] dizi;
    private int elemanSayisi;

    public DiziYonetici(int kapasite)
    {
        dizi = new int[kapasite];
        elemanSayisi = 0;
    }

    // Ekleme metodu
    public void Ekle(int eleman)
    {
        if (elemanSayisi < dizi.Length)
        {
            dizi[elemanSayisi] = eleman;
            elemanSayisi++;
            Console.WriteLine($"{eleman} eklendi.");
        }
        else
        {
            Console.WriteLine("Dizi dolu, eleman eklenemiyor.");
        }
    }

    // Silme metodu
    public void Sil(int eleman)
    {
        int index = Ara(eleman);
        if (index != -1)
        {
            for (int i = index; i < elemanSayisi - 1; i++)
            {
                dizi[i] = dizi[i + 1];
            }
            elemanSayisi--;
            Console.WriteLine($"{eleman} silindi.");
        }
        else
        {
            Console.WriteLine($"{eleman} bulunamadı.");
        }
    }

    // Güncelleme metodu
    public void Guncelle(int eskiDeger, int yeniDeger)
    {
        int index = Ara(eskiDeger);
        if (index != -1)
        {
            dizi[index] = yeniDeger;
            Console.WriteLine($"{eskiDeger} değeri {yeniDeger} olarak güncellendi.");
        }
        else
        {
            Console.WriteLine($"{eskiDeger} değeri bulunamadı.");
        }
    }

    // Arama metodu
    public int Ara(int eleman)
    {
        for (int i = 0; i < elemanSayisi; i++)
        {
            if (dizi[i] == eleman)
            {
                return i;
            }
        }
        return -1; // Bulunamadı
    }

    // Diziyi yazdırma metodu
    public void Yazdir()
    {
        Console.Write("Dizi: ");
        for (int i = 0; i < elemanSayisi; i++)
        {
            Console.Write(dizi[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        DiziYonetici dy = new DiziYonetici(5);

        dy.Ekle(10);
        dy.Ekle(20);
        dy.Ekle(30);
        dy.Yazdir();

        dy.Sil(20);
        dy.Yazdir();

        dy.Guncelle(30, 40);
        dy.Yazdir();

        int index = dy.Ara(40);
        Console.WriteLine(index != -1 ? $"40 bulundu, indeksi: {index}" : "40 bulunamadı.");
    }
}

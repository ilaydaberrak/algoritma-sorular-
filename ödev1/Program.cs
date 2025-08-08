using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hangi ödevi çalıştırmak istiyorsunuz?");
        Console.WriteLine("1 - Çift Sayıları Yazdır");
        Console.WriteLine("2 - m'e Eşit veya Tam Bölünen Sayılar");
        Console.WriteLine("3 - Kelimeleri Tersten Yazdır");
        Console.Write("Seçiminiz (1-3): ");

        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {
            case 1:
                Odev1();
                break;
            case 2:
                Odev2();
                break;
            case 3:
                Odev3();
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                break;
        }
    }

    static void Odev1()
    {
        Console.Write("Kaç sayı gireceksiniz? (pozitif bir sayı): ");
        int n = int.Parse(Console.ReadLine());
        int[] sayilar = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Çift sayılar:");
        foreach (int sayi in sayilar)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine(sayi);
            }
        }
    }

    static void Odev2()
    {
        Console.Write("Kaç sayı gireceksiniz? (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Bölme kontrolü için bir sayı girin (m): ");
        int m = int.Parse(Console.ReadLine());

        int[] sayilar = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"{m} sayısına eşit veya tam bölünen sayılar:");
        foreach (int sayi in sayilar)
        {
            if (sayi == m || sayi % m == 0)
            {
                Console.WriteLine(sayi);
            }
        }
    }

    static void Odev3()
    {
        Console.Write("Kaç kelime gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());

        string[] kelimeler = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. kelime: ");
            kelimeler[i] = Console.ReadLine();
        }

        Console.WriteLine("Kelimeler tersten:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(kelimeler[i]);
        }
    }
}


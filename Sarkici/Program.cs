using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Şarkıcıların listesi
        List<Sarkici> sarkicilar = new List<Sarkici>
        {
            new Sarkici("Ajda Pekkan", "Pop", 1968, 20),
            new Sarkici("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
            new Sarkici("Funda Arar", "Pop", 1999, 3),
            new Sarkici("Sertab Erener", "Pop", 1994, 5),
            new Sarkici("Sıla", "Pop", 2009, 3),
            new Sarkici("Serdar Ortaç", "Pop", 1994, 10),
            new Sarkici("Tarkan", "Pop", 1992, 40),
            new Sarkici("Hande Yener", "Pop", 1999, 7),
            new Sarkici("Hadise", "Pop", 2005, 5),
            new Sarkici("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 5),
            new Sarkici("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2)
        };

        // Adı 'S' ile başlayan şarkıcılar
        var sIleBaslayan = sarkicilar.Where(s => s.AdSoyad.StartsWith("S")).ToList();
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var sarkici in sIleBaslayan)
        {
            Console.WriteLine(sarkici.AdSoyad);
        }

        // Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var onMilyonUstu = sarkicilar.Where(s => s.AlbumSatislari > 10).ToList();
        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        foreach (var sarkici in onMilyonUstu)
        {
            Console.WriteLine(sarkici.AdSoyad);
        }

        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var ikiBinOncesiPop = sarkicilar
            .Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains("Pop"))
            .OrderBy(s => s.CikisYili)
            .ThenBy(s => s.AdSoyad)
            .ToList();
        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        foreach (var sarkici in ikiBinOncesiPop)
        {
            Console.WriteLine($"{sarkici.AdSoyad} - {sarkici.CikisYili}");
        }

        // En çok albüm satan şarkıcı
        var enCokAlbumSatan = sarkicilar.OrderByDescending(s => s.AlbumSatislari).FirstOrDefault();
        Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enCokAlbumSatan?.AdSoyad} - {enCokAlbumSatan?.AlbumSatislari} milyon");

        // En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
        var enYeni = sarkicilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
        var enEski = sarkicilar.OrderBy(s => s.CikisYili).FirstOrDefault();
        Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeni?.AdSoyad} - {enYeni?.CikisYili}");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEski?.AdSoyad} - {enEski?.CikisYili}");
    }
}

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan sayı alınır.
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        // Sayı 10'a eşit mi, küçük mü, büyük mü kontrol edilir.
        if (sayi == 10)
            Console.WriteLine("Girilen sayı 10'a eşittir.");
        else if (sayi < 10)
            Console.WriteLine("Girilen sayı 10'dan küçüktür.");
        else
            Console.WriteLine("Girilen sayı 10'dan büyüktür.");

        // Sayı çift mi, tek mi kontrol edilir ve ekrana yazılır.
        Console.WriteLine(sayi % 2 == 0 ? "Girilen sayı çifttir." : "Girilen sayı tektir.");
    }
}
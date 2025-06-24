using System;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi == 10)
            Console.WriteLine("Girilen sayı 10'a eşittir.");
        else if (sayi < 10)
            Console.WriteLine("Girilen sayı 10'dan küçüktür.");
        else
            Console.WriteLine("Girilen sayı 10'dan büyüktür.");

        Console.WriteLine(sayi % 2 == 0 ? "Girilen sayı çifttir." : "Girilen sayı tektir.");
    }
}
using System;

class Program
{

    static void Main(string[] args)
    {
        int dogruCevapSayisi = 0; // Sayacı başlatır

        Console.WriteLine("Cevaplayacağınız 3 adet sorudan 2 tanesi doğru ise büyük ödülü kazanabilirsiniz!");

        // 1. soru
        Console.WriteLine("1. soru:");
        Console.WriteLine("Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a)Lama b)Deve");

        string cevap1 = Console.ReadLine();

        if (cevap1.ToLower() == "a") //Büyük harf küçük harf duyarlılığını ortadan kaldırır
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }

        else
        {
            Console.WriteLine("Yanlış cevap!");
        }


        //2. soru

        Console.WriteLine("2. soru:");
        Console.WriteLine("Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a)Venüs b)Mars");


        string cevap2 = Console.ReadLine();

        if (cevap2.ToLower() == "a")

        {

            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;

        }
        else
        {
            Console.WriteLine("Yanlış cevap!");

        }

        //3. soru

        Console.WriteLine("3. soru:");
        Console.WriteLine(" 5*2+8/2-2 işleminin sonucu kaçtır?");
        Console.WriteLine("a)7 b)2");

        string cevap3 = Console.ReadLine();

        if (cevap3.ToLower() == "b")

        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }

        else

        {
            Console.WriteLine("Yanlış cevap!");
        }


        // Kazanma durumu kontrolü

        if (dogruCevapSayisi == 2)
        {
            Console.WriteLine("\nTebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }

        else
        {
            Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız!");

        }

        Console.ReadLine();
    }
}
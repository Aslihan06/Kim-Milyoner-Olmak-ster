using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        // Doğru cevap sayısını tutmak için değişken
        int dogruCevapSayisi = 0;

        // 1. Soru
        Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir ?");
        Console.WriteLine("a) Lama");
        Console.WriteLine("b) Deve");
        Console.Write("Cevabınız (a/b): ");
        string cevap1 = Console.ReadLine().ToLower();

        if (cevap1 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Eğer kullanıcı 2 doğru cevabı alma şansını kaybettiyse, oyunu burada bitiriyoruz
        if (dogruCevapSayisi < 1)
        {
            Console.WriteLine("Üzgünüm, büyük ödülü kazanma şansınız kalmadı.");
            return;
        }

        // 2. Soru
        Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
        Console.WriteLine("a) Venüs");
        Console.WriteLine("b) Mars");
        Console.Write("Cevabınız (a/b): ");
        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Eğer kullanıcı 3 doğru cevabı alma şansını kaybettiyse, 3. soruyu sormuyoruz
        if (dogruCevapSayisi < 2)
        {
            Console.WriteLine("Üzgünüm, büyük ödülü kazanma şansınız kalmadı.");
            return;
        }

        // 3. Soru
        Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
        Console.WriteLine("a) 7");
        Console.WriteLine("b) 12");
        Console.Write("Cevabınız (a/b): ");
        string cevap3 = Console.ReadLine().ToLower();

        if (cevap3 == "b")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }

        // Sonuçları değerlendirme
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Üzgünüm, büyük ödülü kazanamadınız.");
        }
    }
}
using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 10;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyati = 10;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----Metotlar------");

            //instance-örnek
            //encapsulation; sınıfta tanımlamak yeni özellik eklendiğinde sınıfta eklemek.
            //Bir düzene sokmak demek yani kapsüllemek.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12);
            sepetManager.Ekle2("Elma", "yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);
        }
    }
}
//tekrar tekrar kullanabilmeyi sağlar(metotlar)
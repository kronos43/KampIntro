using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            
            //bool sistemeGirisYapmisMi = sistemeGirisYapmisMiBiBak(); gerçek hayattaki hali
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullancı Ayarlar Butonu");
            }
            else 
            {
                Console.WriteLine("Giriş Yap Butonu");           
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}

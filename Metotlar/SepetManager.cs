using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler,sepete eklendi : " + product.Adi);
        }

        //Yanlış örnek:
        public void Ekle2(string urunAdi, string aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler,sepete eklendi : " + urunAdi);
        }

    }
}

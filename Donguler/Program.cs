using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım yetiştirme kursu";
            string kurs2 = "Programlamaya Başlangıcı";
            string kurs3 = "Java";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım yetiştirme kursu", "Programlamaya baslangic", "Java", "Python" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach  (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        
        
        
        }



    }
}

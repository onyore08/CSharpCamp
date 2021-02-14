using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                TC_NO=689464845,
                Ad = "Mehmet",
                Soyad = "Günsur",
                Cinsiyet = 'E',
                Yas = 23,
                GSM = 04984156
            };

            MusteriManager musteriManager = new MusteriManager();

            //Ekleme
            musteriManager.Ekle(musteri);


            //Silme
            //musteriManager.Sil(musteri);

            //Listeleme
            musteriManager.Listele();
        }
    }
    
}

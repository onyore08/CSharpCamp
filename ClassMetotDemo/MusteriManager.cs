using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> _musteriler;
        public MusteriManager()
        {
            _musteriler = new List<Musteri>
            {
                new Musteri{TC_NO=213123123323,Ad = "Furkan",Soyad = "Gündoğdu",Cinsiyet = 'E',Yas = 25,GSM = 01234569778},
                new Musteri{TC_NO=123124325145,Ad = "Ahmet",Soyad = "Kasımpatı",Cinsiyet = 'E',Yas = 35,GSM = 0564155451},
                new Musteri{TC_NO=462565765664,Ad = "Nazlı",Soyad = "Güzel",Cinsiyet = 'K',Yas = 23,GSM = 012312453},
                new Musteri{TC_NO=572657356324,Ad = "Abdullah",Soyad = "Halterci",Cinsiyet = 'E',Yas = 12,GSM = 0123123123},
                new Musteri{TC_NO=523534265555,Ad = "Hakan",Soyad = "Aksu",Cinsiyet = 'E',Yas = 54,GSM = 0231512135},
            };
        }

        public void Ekle(Musteri musteri)
        {
            _musteriler.Add(musteri);
            Console.WriteLine("Müşteri eklenmiştir");
        }

        public void Sil(Musteri musteri)
        {
            Musteri musteriToDelete = _musteriler.SingleOrDefault(p => p.TC_NO == musteri.TC_NO);
            _musteriler.Remove(musteriToDelete);
        }
        public void Listele()
        {
            int i = 1;
            foreach (var list in _musteriler)
            {
                Console.WriteLine($"{i}. Müşteri  :{list.TC_NO} - {list.Ad} {list.Soyad}");
                i++;
            }
        }
    }
}
 
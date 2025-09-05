using System.Threading.Tasks.Dataflow;

namespace uyanis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // KDV Tutarı Hesaplayan Program

            /* Console.WriteLine("KDV Tutar Hesaplama Programına Hoşgeldiniz!");

            Console.Write("KDV: ");
            double vergi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tutar: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ürünün KDV'li Fiyatı: " + (fiyat + (fiyat * vergi / 100))); */

            // **********************************************************************************

            // Not Ortalamasını Hesaplayan Program

            /* Console.Write("Vize Notu: ");
            double vize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Final Notu: ");
            double ffinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ortalamanız: " + (((vize * 40) / 100) + ((ffinal * 60) / 100))); */

            // **********************************************************************************

            // Dairenin Alan ve Çevresi

            /* Console.Write("Dairenin Yarıçapını Giriniz: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;

            Console.WriteLine("Dairenin Çevresi : " + (2 * yaricap * pi));

            Console.WriteLine("Dairenin Alanı: " + (pi * yaricap * yaricap)); */

            // **********************************************************************************

            // Taksimetre Hesaplama

            /* Console.WriteLine("Taksi Lazımdır Abi");

            Console.WriteLine("Açılış Ücreti 31 TL");
            int acilis = 31;
            Console.WriteLine("KM başına ücret 3 TL");

            Console.WriteLine("Nereye gidisi abi (Kaç Km): ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Abi senin ücret " + ((km*3)+acilis)); */

            // **********************************************************************************

            // Hipotenüs Bulan Program

            /* Console.Write("Kenar a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kenar b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("Hipotenüs Uzunluğu: " + c); */

            // **********************************************************************************
            // **********************************************************************************

            // Uçak Bileti Hesapayan Program

            /*
            Console.WriteLine("Nabi Hava Yollarına Hoşgeldiniz!");
            Console.WriteLine("Lütfen Yolculuk Tipini Seçiniz: " +
                "1: Tek Gidiş, 2: Gidiş Dönüş");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen Mesafeyi Giriniz: ");
            double mesafe = Convert.ToDouble(Console.ReadLine());

                double mil_Basina_Ucret = 0.10;
                double ucret = mesafe * mil_Basina_Ucret;

            if (yas < 18)
                ucret *= 0.5;

            if (secim == 2)
            {
                ucret *= 2 * 0.8;
            }else if(secim != 1)
            {
                Console.WriteLine("Lütfen Bilet Tipini Uygun Numaralarla Seçiniz!");
                return;
            }

            Console.WriteLine("Bilet Tutarı: " + ucret);
            */

            // Hesap Makinesi

            /* Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz: " +
            "1: Toplama " +
            "2: Çıkarma " +
            "3: Çarpma " +
            "4: Bölme ");

            int islem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Console.WriteLine(a+b);
            }
            else if (islem == 2)
            {
                Console.WriteLine(a-b);
            }
            else if (islem == 3)
            {
                Console.WriteLine(a*b);
            }
            else if (islem == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Gardaş Tanımsız İşlem Yaptın!");
                }
                else
                {
                    Console.WriteLine(a/b);
                }
            }
            else
            {
                Console.WriteLine("Gardaş yanlış tuşlama yaptın! Lütfen geçerli bir rakam gir!");
            } */

            // Hava Sıcaklığına Göre Etkinlik Önerme

            /* Console.WriteLine("Lütfen hava sıcaklığını giriniz: ");
             double sicaklik = Convert.ToDouble(Console.ReadLine());

             if (sicaklik > 0)
             {
                 Console.WriteLine("Koşu yapabilirsin");
             }
             else if (sicaklik == 0)
             {
                 Console.WriteLine("Evde otur be ya");
             }else

             {
                 Console.WriteLine("Kayak Yapmaya gidebilirsin");
             }
                 */

            // Büyükten Küçüğe Sıralama

            /*
            Console.WriteLine("Lütfen sıralamak istediğiniz sayıları giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                if (sayi2 > sayi3)
                {
                    Console.WriteLine($"{sayi1}, {sayi2}, {sayi3}");
                }
                else
                {
                    Console.WriteLine($"{sayi1}, {sayi3}, {sayi2}");
                }
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                if (sayi1 > sayi3)
                {
                    Console.WriteLine($"{sayi2}, {sayi1}, {sayi3}");
                }
                else
                {
                    Console.WriteLine($"{sayi2}, {sayi3}, {sayi1}");
                }
            }
            else
            {
                if (sayi1 > sayi2)
                {
                    Console.WriteLine($"{sayi3}, {sayi1}, {sayi2}");
                }
                else
                {
                    Console.WriteLine($"{sayi3}, {sayi2}, {sayi1}");
                }
            }

            */

            // Burç Hesaplama
           
            /*

            Console.WriteLine("Lütfen hangi ay doğdunuzu giriniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen hangi gün doğdunuzu giriniz");
            int gün = Convert.ToInt32(Console.ReadLine());

            if(ay < 1 || ay > 12 || gün < 1 || gün > 31)
            {
                Console.WriteLine("Gardaş tarih yanlış");
            }
            else
            {
                if ((ay == 3 && gün >= 21) || (ay == 4 && gün <= 19))
                    Console.WriteLine("Koç");
                else if ((ay == 4 && gün >= 20) || (ay == 5 && gün <= 20))
                    Console.WriteLine("Boğa");
                else if ((ay == 5 && gün >= 21) || (ay == 6 && gün <= 20))
                    Console.WriteLine("İkizler");
                else if ((ay == 6 && gün >= 21) || (ay == 7 && gün <= 22))
                    Console.WriteLine("Yengeç");
                else if ((ay == 7 && gün >= 23) || (ay == 8 && gün <= 22))
                    Console.WriteLine("Aslan");
                else if ((ay == 8 && gün >= 23) || (ay == 9 && gün <= 22))
                    Console.WriteLine("Başak");
                else if ((ay == 9 && gün >= 23) || (ay == 10 && gün <= 22))
                    Console.WriteLine("Terazi");
                else if ((ay == 10 && gün >= 23) || (ay == 11 && gün <= 21))
                    Console.WriteLine("Akrep");
                else if ((ay == 11 && gün >= 22) || (ay == 12 && gün <= 21))
                    Console.WriteLine("Yay");
                else if ((ay == 12 && gün >= 22) || (ay == 1 && gün <= 19))
                    Console.WriteLine("Oğlak");
                else if ((ay == 1 && gün >= 20) || (ay == 2 && gün <= 18))
                    Console.WriteLine("Kova");
                else if ((ay == 2 && gün >= 19) || (ay == 3 && gün <= 20))
                    Console.WriteLine("Balık");
            }
            */

            
        }
    }
}
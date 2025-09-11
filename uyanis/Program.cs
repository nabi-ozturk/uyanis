namespace uyanis
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            // İLK KONULAR

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

            // ************************************************************************
            // ************************************************************************

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

            // Çift Sayıları Bulan Program

            /*
            Console.WriteLine("Bulunacak çift sayıların aralığını belirleyiniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (baslangic > bitis)
            {
                int temp = baslangic;
                baslangic = bitis;
                bitis = temp;
            }

            for(int i = baslangic + 1; i < bitis; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Sonuçlar: " + i);
                }
            }
            */

            // Tek Sayıların Toplamını Bulan Program

            /*
            Console.WriteLine("Toplanacak Tek Sayıların Aralığını Belirleyiniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            int bitis = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            if(baslangic > bitis)
            {
                int temp = baslangic;
                baslangic = bitis;
                bitis = temp;
            }
            for(int i = baslangic + 1; i < bitis; i++)
            {
                if(i % 2 == 1)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("Tek Sayıların Toplamı: " + toplam);

            */

            // Üslü Sayı Hesaplama

            /*
            Console.WriteLine("Lütfen taban değeri giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen üs değeri giriniz: ");
            int üs = Convert.ToInt32(Console.ReadLine());

            int sonuc = 1;
            for (int i = 0; i < üs; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine(sonuc);

            */

            // Faktöriyel Hesaplama

            /*
            Console.WriteLine("Faktöriyel Alınacak Sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = 1;

            for(int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            Console.WriteLine(sonuc);
            */

            // Harmonik Sayılar

            /*
            Console.WriteLine("Harmonik Sayının Sınırını Belirleyiniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double toplam = 0;

            for(int i = 1; i <= n; i++)
            {
                toplam += 1.0 / i;
            }

            Console.WriteLine(toplam);

            */

            // Kuvvet Hesaplama

            /*
            Console.WriteLine("Kaç adet kütle hesaplamak istiyorsunuz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            

            for(int i = 1; i <= adet; i++)
            {
                Console.WriteLine("Kütle: ");
                int kütle = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İvme: ");
                int ivme = Convert.ToInt32(Console.ReadLine());

                double kuvvet = kütle * ivme;
                Console.WriteLine(kuvvet);
            }
            */

            // Asal Sayı Hesaplama

            /*
            Console.WriteLine("Asal Sayıyı Giriniz: ");
            int asal = Convert.ToInt32(Console.ReadLine());

            bool asalMi = true;

            for(int i = 2; i < asal; i++)
            {
                if(asal % i == 0)
                {
                    asalMi = false;
                    break;
                }                
            }
            if (asalMi && asal > 1)
            {
                Console.WriteLine("Asal");
            }
            else
            {
                Console.WriteLine("Asal Değil");
            }
            */

            // Armstrong Sayılar

            /*
            Console.WriteLine("Armstrong Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int temp1 = sayi;
            int basamakSayisi = 0;

            while (temp1>0)
            {
                basamakSayisi++;
                temp1 = temp1 / 10;
            }

            int temp2 = sayi;
            int toplam = 0;

            while (temp2 > 0)
            {
                int basamak = temp2 % 10;
                int kuvvet = 1;

                for(int i = 1; i <= basamakSayisi; i++)
                {
                    kuvvet *= basamak;
                }

                toplam += kuvvet;
                temp2 = temp2 / 10;
            }

            if(toplam == sayi)
            {
                Console.WriteLine("Girilen Sayı Armstrong Sayıdır");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Armstrong Sayı Değildir");
            }

            */

            // Fibonacci Serisi

            /*
            Console.WriteLine("Fibonacci Serisininde İstediğiniz Sırayı Yazınız: ");
            int fibo = Convert.ToInt32(Console.ReadLine());

            int ilkSayi = 1;
            int İkinciSayi = 1;
            int sonuc = 1;

            if(fibo == 1 || fibo == 2)
            {
                sonuc = 1;
            }
            else
            {
                for(int i = 3; i <= fibo; i++)
                {
                    sonuc = ilkSayi + İkinciSayi;
                    ilkSayi = İkinciSayi;
                    İkinciSayi = sonuc;
                }
            }
            Console.WriteLine(sonuc);
            */

            // EBOB

            /*
            Console.WriteLine("ilk sayı: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayı: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int ebob = 1;

            for(int i = 1; i <= Math.Min(s1, s2); i++)
            {
                if(s1%i==0 && s2%i==0)
                {
                    ebob = i;
                }
            }
            Console.WriteLine(ebob);
            */

            // EKOK

            /*
            Console.WriteLine("İlk sayı: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayı: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            int ekok = Math.Max(s1, s2);

            while (true)
            {
                if(ekok%s1==0 && ekok%s2==0)
                {
                    break;
                }
                ekok++;
            }

            Console.WriteLine(ekok);
            */

            // ATM Projesi

            /*
            int bakiye = 10000;
            bool devamMi = true;

            while(devamMi)
            {
                Console.WriteLine("NabiBank'a Hoşgeldiniz\nLütfen Yapmak İstediğiniz İşlemi Seçiniz:\n1:Para Yatırma\n2:Para Çekme" +
                "\n3:Bakiye Sorgulama\n4:Çıkış");
                int islem = Convert.ToInt32(Console.ReadLine());

                if (islem < 1 || islem > 4)
                {
                    Console.WriteLine("Hatalı İşlem Girdiniz!\nLütfen Geçerli Bir İşlem Yapınız!");
                    continue;

                }
                if (islem == 1)
                {
                    Console.WriteLine("Yatırmak İstediğiniz Miktarı Giriniz: ");
                    int para_Yatir = Convert.ToInt32(Console.ReadLine());
                    bakiye += para_Yatir;
                }else if(islem == 2)
                {
                    Console.WriteLine("Çekmek İstediğiniz Para Miktarını Giriniz: ");
                    int para_Cek = Convert.ToInt32(Console.ReadLine());

                    if(bakiye<para_Cek)
                    {
                        Console.WriteLine("Yetersiz Bakiye!");
                        continue;
                    }
                    bakiye -= para_Cek;
                }else if(islem == 3)
                {
                    Console.WriteLine("Bakiyeniz: " + bakiye + "$");
                }
                else
                {
                    Console.WriteLine("Çıkış Yapıldı");
                    break;
                }
            }          
            */

            // *********************************************************************
            // *********************************************************************

            // METHODLAR

            // Palindrom Sayılar

            /* Console.WriteLine("Palindrom Konrolü! Lütfen Bir Sayı Giriniz: ");
            string sayi = Console.ReadLine();

            if (PalindromMu(sayi))
            {
                Console.WriteLine("Evet, Palindrom Sayıdır!");
            }
            else
            {
                Console.WriteLine("Hayır, Palindrom Sayı Değildir!");
            }    */

            // Fibonacci Serisi
            /*
                Console.WriteLine("Fibonacci Serisinin n. terimini giriniz: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int sonuc = Fibo(n);
                Console.WriteLine(sonuc);
            */

            // Metotlar ile Hesap Makinesi

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:\n1: Toplama\n2: Çıkarma\n3: Çarpma\n4: Bölme");
            int islem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine(Topla(a, b));
                    break;
                case 2:
                    Console.WriteLine(Cikar(a, b));
                    break;
                case 3:
                    Console.WriteLine(Carp(a, b));
                    break;
                case 4:
                    Console.WriteLine(Böl(a, b));
                    break;
                default:
                    Console.WriteLine("Geçersiz İşlem Girdiniz!");
                    break;
            }

        } // Main

        static int Topla(int a, int b)
        {
            return a + b;
        }
        static int Cikar(int a, int b)
        {
            return a - b;
        }
        static int Carp(int a, int b)
        {
            return a * b;
        }
        static int Böl(int a, int b)
        {
            return a / b;
        }


        /* static int Fibo(int n)
      {
          if (n <= 1)
          {
              return n;


          }
          else
          {
              return Fibo(n - 1) + Fibo(n - 2);
          }
      } 

      */
        /* Palindrom Sayılar
         * static bool PalindromMu(string sayi)
        {
            string ters = "";
            for (int i =sayi.Length -1; i >= 0; i--)
            {
                ters += sayi[i];
            }
            return sayi == ters;



        } */



    } // Class
}


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
        }
    }
}

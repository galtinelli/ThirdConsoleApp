using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 5 sayının aritmetik ortalamasını hesaplayıp yazdıran program

            //Console.Write("İlk sayıyı giriniz: ");
            //double a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //double b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Ucuncu sayıyı giriniz: ");
            //double c = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Dorduncu sayıyı giriniz: ");
            //double d = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Beşinci sayıyı giriniz: ");
            //double e = Convert.ToInt32(Console.ReadLine());

            //double ort=( a + b + c + d + e) / 5;


            for (int i = 1; i <6 ; i++)
            {
                Console.WriteLine(i + ". sayi giriniz");
                double sayi = Convert.ToDouble(Console.ReadLine());
                double toplam=0 ;
                toplam = toplam + sayi;
                double ort = toplam / i;
                Console.WriteLine("Girilen sayilarin aritmetik ortalaması: " + ort);
                
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen fiyatın kdvli fiyatını hesapla

            Console.Write("Fiyat girişi yapınız: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());

            double kdvliFiyat = fiyat * 1.18;
            Console.WriteLine("Fiyatın Kdvli Fyatı: "+kdvliFiyat);
            Console.ReadKey();

            //HB66FPNG31
            //HB34MBNA94

            decimal D = 1;
        }
    }
}

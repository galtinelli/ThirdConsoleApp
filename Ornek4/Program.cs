using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Sayı: "+sayi1);
            Console.WriteLine("2. Sayı: "+sayi2);

            int sayi3;

            sayi3 = sayi1;
            sayi1 = sayi2;
            sayi2 = sayi3;

            Console.WriteLine("Değişiklik Sonrası");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Sayı: " + sayi1);
            Console.WriteLine("2. Sayı: " + sayi2);

            

            Console.ReadKey();
        }
    }
}

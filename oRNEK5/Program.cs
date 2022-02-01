using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oRNEK5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İlk sayiniz: "+sayi1);
            Console.WriteLine("İkinci sayiniz: "+sayi2);

            int sayi3;

            sayi3 = sayi1;
            sayi1 = sayi2;
            sayi2 = sayi3;
            

            Console.WriteLine("Değişiklik Sonrası");
            Console.WriteLine("İlk sayiniz: " + sayi1);
            Console.WriteLine("İkinci sayiniz: " + sayi2);
            Console.ReadLine();
        }
    }
}

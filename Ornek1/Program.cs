using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden kullanıcının grdiği adı alan ve ekrana "Merhaba Kullanıcı şeklince yazdıran program"

            Console.WriteLine("Adınızı giriniz ");
            string ad = Console.ReadLine();
            Console.WriteLine("Merhaba " + ad);
            Console.ReadKey();


        }
    }
}

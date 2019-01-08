using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine(graf);
            Console.WriteLine("\nMélységbejárás");
            graf.melysegBejar(2);
            Console.WriteLine("\nSzélességbejárás");
            graf.szelessegBejar(2);

            Console.WriteLine("\nGráf összefüggőség: " + graf.osszefuggo());
            Console.WriteLine("\nFeszítőfa");
            Console.WriteLine(graf.feszitoFa());







            
            Console.ReadLine();
        }
    }
}

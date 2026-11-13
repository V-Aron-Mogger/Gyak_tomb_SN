using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egy meteorológiai állomás egy hét alatt minden nap rögzíti a hőmérsékletet. A mért adatokat egy egész számokat tartalmazó tömbben tároljuk. 
            int[] homersekletek = { 12, 8, -1, 5, 14, 7, 2};
            //Írjon programot, amely a tömb adatai alapján meghatározza a hét legalacsonyabb és legmagasabb hőmérsékletét
            //és az átlaghőmérsékletet is !A program írja ki a minimum - és maximumértéket, és az átlagot a konzolra.
            int legkis = 100;
            int legnagy = 0;
            int ossz = 0;
            for (int i = 0; i < homersekletek.Length; i++)
            {
                if (legkis > homersekletek[i])
                {
                    legkis = homersekletek[i];
                }
                else if (legnagy < homersekletek[i])
                {
                    legnagy = homersekletek[i];
                }
            }
            Console.WriteLine("A heti hőmérsékletek: ");
            Console.WriteLine(String.Join(" ",homersekletek));
            Console.WriteLine($"A legalacsonyabb hőmérséklet:{legkis} °C");
            Console.WriteLine($"A legmagasabb hőmérséklet:{legnagy} °C");
            Console.WriteLine($"A heti átlag hőmérséklet:{Math.Round(homersekletek.Average(),1)}°C");
            Console.ReadKey();
        }
    }
}

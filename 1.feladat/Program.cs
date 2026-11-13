using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feltölt egy 10 elemű tömböt 1 és 100 közötti egészekkel és kiírja a benne lévő páros és páratlan számok számát! 
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,101);
            }
            Console.WriteLine(String.Join(" ",szamok));
            int paros=0;
            int parat=0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]%2 == 0)
                {
                    paros++;
                }
                else if (szamok[i]% 2 == 1)
                {
                    parat++;
                }
            }
            Console.WriteLine($"A páros számok száma: {paros}");
            Console.WriteLine($"A páratlan számok száma: {parat}");
            Console.ReadKey();
        }
    }
}

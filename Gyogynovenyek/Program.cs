using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> novenyek = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                novenyek.Add(new Noveny(file.ReadLine()));
            }
            file.Close();
        }

        static void feladat1()
        {
            Console.WriteLine("Növények száma: {0}",novenyek.Count());
        }

        static void feladat2()
        {
            Console.WriteLine("\n2. feladat: gyűjthető részek.");
            foreach (var n in novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }
            }

            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }

            foreach (var r in reszek)
            {
                Console.WriteLine(r.Key + ";" + r.Value);
            }
        }

        static void feladat3()
        {
            int max = 0;
            foreach (var n in novenyek)
            {
                if (n.Idotartam > max)
                {
                    max = n.Idotartam;
                }
            }

            foreach (var n in novenyek)
            {
                if (max == n.Idotartam)
                {
                    Console.WriteLine("\nA legtöbb idő amíg gyűjthető: {0}, {1}",max, n.Nev);
                }
            }
        }

        static void feladat4()
        {
            double db = 0;
            int osszeg = 0;
            foreach (var n in novenyek)
            {
                osszeg += n.Idotartam;
                db++;
            }
            Console.WriteLine("Átlagos gyűjthető időtartam: {0}", osszeg / db);
        }

        static void Main(string[] args)
        {
            Beolvas();
            feladat1();
            feladat2();
            feladat3();
            feladat4();

            Console.ReadKey();
        }
    }
}

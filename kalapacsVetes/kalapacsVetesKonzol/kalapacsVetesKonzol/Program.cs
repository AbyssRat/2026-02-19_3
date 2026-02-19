using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace kalapacsVetesKonzol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> sportolok = new List<Sportolo>();
            string[] sorok = File.ReadAllLines("kalapacsvetes.txt");

            for (int i = 1; i < sorok.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(sorok[i]))
                    continue;

                string[] adatok = sorok[i].Split(';');

                int helyezes = int.Parse(adatok[0].Trim());
                double eredmeny = double.Parse(adatok[1].Replace(',', '.').Trim(), CultureInfo.InvariantCulture);
                string nev = adatok[2].Trim();
                string orszag = adatok[3].Trim();
                string helyszin = adatok[4].Trim();
                DateTime datum = DateTime.ParseExact(adatok[5].Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture);

                sportolok.Add(new Sportolo(helyezes, eredmeny, nev, orszag, helyszin, datum));
            }

            // 4
            int dobasokSzama = sportolok.Count;
            Console.WriteLine($"4. feladat: {dobasokSzama} dobás eredménye található.");

            // 5
            var magyarDobasok = sportolok.Where(s => s.Orszag == "HUN").Select(s => s.Eredmeny);
            if (magyarDobasok.Any())
            {
                double atlag = magyarDobasok.Average();
                Console.WriteLine($"5. feladat: A magyar sportolók átlagosan: {Math.Round(atlag, 2)} métert dobtak");
            }
            else
            {
                Console.WriteLine("Nincsenek magyar sportolók az állományban.");
            }

            // 6
            Console.Write("6. feladat: Adjon meg egy évszámot: ");
            int ev = int.Parse(Console.ReadLine());

            var adottEvLegjobbak = sportolok
                .Where(s => s.Datum.Year == ev && s.Helyezes <= 50)
                .ToList();

            if (adottEvLegjobbak.Any())
            {
                Console.WriteLine($"Az {ev}-es évben {adottEvLegjobbak.Count} dobás került be a legjobbak közé.");
                Console.WriteLine("Sportolók, akik elérték ezeket:");
                foreach (var s in adottEvLegjobbak)
                {
                    Console.WriteLine($"- {s.Nev} ({s.Orszag}) - {s.Eredmeny} m, helyezés: {s.Helyezes}");
                }
            }
            else
            {
                Console.WriteLine($"Az {ev}-es évben nem került be egy dobás eredménye sem a legjobbak közé.");
            }

            // 7
            var legjobbDobasok = sportolok.Where(s => s.Helyezes <= 50);
            var statisztika = legjobbDobasok
                .GroupBy(s => s.Orszag)
                .Select(g => new { Orszag = g.Key, DobasokSzama = g.Count() })
                .OrderByDescending(g => g.DobasokSzama);

            Console.WriteLine("\n7. feladat: Országonkénti statisztika a legjobb dobásokból:");
            foreach (var s in statisztika)
            {
                Console.WriteLine($"{s.Orszag} - {s.DobasokSzama} dobás");
            }

            // 8
            var magyarSportolok = sportolok.Where(s => s.Orszag == "HUN").ToList();
            if (magyarSportolok.Any())
            {
                using (StreamWriter sw = new StreamWriter("magyarok.txt", false, Encoding.UTF8))
                {
                    sw.WriteLine("Helyezes;Eredmeny;Sportolo;Orszag;Helyszin;Datum");
                    foreach (var s in magyarSportolok)
                    {
                        sw.WriteLine($"{s.Helyezes};{s.Eredmeny.ToString(CultureInfo.InvariantCulture)};{s.Nev};{s.Orszag};{s.Helyszin};{s.Datum:yyyy.MM.dd}");
                    }
                }
                Console.WriteLine("\n8. feladat: A magyar sportolók adatai sikeresen kiírásra kerültek a magyarok.txt fájlba (debugban van).");
            }
            else
            {
                Console.WriteLine("Nincsenek magyar sportolók az állományban, így a fájl nem jött létre.");
            }

        }
    }
}

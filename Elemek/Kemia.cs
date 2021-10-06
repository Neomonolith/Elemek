using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kemia
{
  class Program
  {
    static List<Elem> elemek = new List<Elem>();
    static string vegyjel = String.Empty;
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      
      Console.ReadKey();
    }
    private static void HatodikFeladat()
        {
            int i = 0;
            while (i < elemek.Count && elemek[i].vegyjel.ToLower() != vegyjel.ToLower())
            {
                i++;
            }
            if (i < lista.Count)
            {
              Console.WriteLine($"Az elem vegyjele: {elemek[i].vegyjel}");
              Console.WriteLine($"Az elem neve: {elemek[i].Nev}");
              Console.WriteLine($"Rendszám: {elemek[i].Rszam}");
              Console.WriteLine($"Felfedezés éve: {elemek[i].ev}");
              Console.WriteLine($"Felfedező: {elemek[i].Tudos}");
            }
                else
                {
                    Console.WriteLine("Nem létezik ilyen elem.");
                }
        }
    private static void OtodikFeladat()
    {
      bool nemjo = false;
      do
      {

        nemjo = false;
        Console.Write("5. feladat: Kérek egy vegyjelet: ");
        vegyjel = Console.ReadLine();
        vegyjel = vegyjel.ToLower();


        if (vegyjel.Length > 2 || vegyjel == "")
        {
          nemjo = true;
        }
        foreach (var v in vegyjel)
        {
          if (v > 'z' || v < 'a')
          {
            nemjo = true;
          }
        }
      } while (nemjo);
    }

    private static void NegyedikFeladat()
    {
      int db = 0;
      foreach (var e in elemek)
      {
        if (e.Ev == "Ókor")
        {
          db++;
        }
      }
      Console.WriteLine("4. feladat: Felfedezések száma az ókorban: {0}", db);
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine("3. feladat: Elemek száma: {0}", elemek.Count());
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("felfedezesek.csv");
      be.ReadLine();
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        elemek.Add(new Elem(a[0], a[1], a[2], int.Parse(a[3]), a[4]));
      }
      be.Close();

      Console.WriteLine("2. feladat: adatok beolvasása");
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kémia
{
  class Program
  {
    static List<data> lista = new List<data>();
    static void Main(string[] args)
    {
      int[] tomb = new int[500];
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladaz();
    }

        private static void NyolcadikFeladaz()
        {
            Dictionary<string, int> stat = new Dictionary<string, int>();
            int i = 0;
            while (lista[i].ev == "Ókor")
            {
                i++;
            }
            for (int j = 0; j < lista.Count; j++)
            {
                if (!stat.ContainsKey(lista[j].ev))
                {
                    stat.Add(lista[j].ev, 1);
                }
                else
                {
                    stat(lista[j].ev)++;
                }
                j++;
            }
            
        }

        private static void HetedikFeladat()
        {
            int i = 0;
            
            while (lista[i].ev == "Ókor")
            {
                i++;
            }
            int max = Convert.ToInt32(lista[i+1].ev) - Convert.ToInt32(lista.[i].ev);
            while (i < lista.Count -1)
            {
                if (max < Convert.ToInt32(lista[i + 1].ev) - Convert.ToInt32(lista.[i].ev))
                {
                    max = Convert.ToInt32(lista[i + 1].ev) - Convert.ToInt32(lista.[i].ev);
                }
            }
            Console.WriteLine($"7.Feladat:{max} év volt!");
        }

        private static void HatodikFeladat()
        {
            int i = 0;
            while (i < lista.Count && lista[i].Vegyjel.ToLower() != Vegyjel.ToLower())
            {
                i++;
            }
            if (i < lista.Count)
            {
                Console.WriteLine("Keresés:");
                Console.WriteLine($"Az elem vegyjele: {lista[i].Vegyjel}");
                Console.WriteLine($"Az elem neve: {lista[i].Nev}");
                Console.WriteLine($"Rendszáma: {lista[i].Rszam}");
                Console.WriteLine($"Felfedezés éve: {lista[i].ev}");
                Console.WriteLine($"Felfedező: {lista[i].Tudos}");
            }
            else
            {
                Console.WriteLine("Nincs ilyen elem az adatforrásban.");
            }
        }

        private static void OtodikFeladat()
        {
            bool nemjo = false;
            Console.WriteLine("Kérem a vegyjelet: ");
            string vegyjel = Console.ReadLine();
            if (vegyjel.Length > 2)
            {
                nemjo = true;
            }
            foreach (var v in vegyjel)
            {
                if (!(v >= 'A' && v <= 'Z') || !(v >= 'a' && v <= 'z'))
                {
                    nemjo = true;
                }
            }
        }

        private static void NegyedikFeladat()
    {
      int db = 0;
      foreach (var l in lista)
      {
        if (l.ev == "Ókor")
        {
          db++;
        }
      }
      Console.WriteLine($"4.Feladat: Felfedezések száma az ókorban: {0}");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3.Feladat: Elemek száma: {lista.Count}");
    }

    private static void MasodikFeladat()
    {
      StreamReader olv = new StreamReader("felfedezesek.csv");
      while (!olv.EndOfStream)
      {
        string[] a = olv.ReadLine().Split(';');
        lista.Add(new data(a[0], a[1], a[2], Convert.ToInt32(a[3]), a[4]));
      }
      olv.Close();
    }
  }
}

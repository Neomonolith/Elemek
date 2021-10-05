using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Elemek
{
  class Program
  {


    static List<Elem> Elemek = new List<Elem>();
    static void Main(string[] args)
    {
     

      masodikfeladat();
      harmadikfeladat();
      negyedikfeladat();
      otodikfeladat();
      hatodikfeladat();
      Console.ReadKey();
    }

        private static void hatodikfeladat()
        {
           
            for (int i = 0; i < Elemek.Count(); i++)
            {
                i++;


                if (i < Elemek.Count())
                {
                    Console.WriteLine("Mindent a minta");
                }
                else
                {
                    Console.WriteLine("Nincs ilyen elem az adatforrásban");
                }
            }

            
        }

        private static void otodikfeladat()
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

        private static void negyedikfeladat()
     {
            int db = 0;

            foreach (var e in Elemek)
            {
                if (e.Ev == "Ókor")
                {
                    db++;
                }
            }
            Console.WriteLine("4. feladat: Felfedezések száma az ókorban:",db);
     }

        private static void harmadikfeladat()
    {
      Console.WriteLine("3. Feladat: Elemek száma", Elemek.Count());
    }

    private static void masodikfeladat()
    {

      Console.WriteLine("2. Feladat: adatok beolvasása");
      StreamReader be = new StreamReader("felfedezesek.csv");


      be.ReadLine();


      while (!be.EndOfStream)
      {

        string[] a = be.ReadLine().Split(';');
        Elemek.Add(new Elem(a[0], a[1], a[2],int.Parse(a[3]),a[4]));

      }
      be.Close();


    }


  }
}

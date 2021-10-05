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

      Console.ReadKey();
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

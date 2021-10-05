using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek
{
  class Elem
  {
    private string ev;

    public string Ev
    {
      get { return ev; }
      set { ev = value; }
    }

    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }

    private string vegyjel;

    public string Vegyjel
    {
      get { return vegyjel; }
      set { vegyjel = value; }
    }

    private int rszam;

    public int Rszam
    {
      get { return rszam; }
      set { rszam = value; }
    }


    private string tudos;

    public string Tudos
    {
      get { return tudos; }
      set { tudos = value; }
    }

    public Elem(string ev, string nev, string vegyjel, int rszam, string tudos)
    {
      this.ev = ev;
      this.nev = nev;
      this.vegyjel = vegyjel;
      this.rszam = rszam;
      this.tudos = tudos;
    }
  }
}

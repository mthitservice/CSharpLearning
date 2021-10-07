using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeKlassen
{
   public class Auto: Fahrzeug
    {

        public Auto(int laenge, int breite, string Marke ,string fznr)
        {
            this.laenge = laenge;
            this.breite = breite;
            this.Marke = Marke;
            this.fznr = fznr;

        }

        public override string ToString()
        {
            return String.Format("Auto länge:{0} breite:{1} marke:{2}", laenge, breite, Marke);
        }
        public Auto()
        {


        }

        public void hupen()
        {
            Console.WriteLine("Autohup");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeKlassen
{
   public class Motorad :Fahrzeug
    {

        public Motorad(int laenge=1,int breite=6,string Marke="Porsche",string fznr="")
        {
            this.laenge = laenge;
            this.breite = breite;
            this.Marke = Marke;
            this.fznr = fznr;

        }
        public Motorad()
        {
          

        }

        public override string ToString()
        {
            return String.Format("Motorad länge:{0} breite:{1} marke:{2}", laenge, breite, Marke);
        }

        public void hupen()
        {
            Console.WriteLine("Motorradhup");
        }
    }
}

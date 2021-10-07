using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisierung
{

    // Modellklasse(reale Strukturen abbilden) ( ohne Funktionen)
   public class Auto: IFahrzeug
    {
        public int Breite { get; set; }
        public int Laenge { get; set; }
        public string Marke { get; set; }
        public string Fznr { get; set; }

    }
}

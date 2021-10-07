using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisierung
{ // Kennzeichn das diese Klasse serialisirt werden darf
    [Serializable]
    // Modellklasse(reale Strukturen abbilden) ( ohne Funktionen)
   public class Auto
    {
        private float _tankinhalt { get; set; }
        public int Breite { get; set; }
        public int Laenge { get; set; }
        public string Marke { get; set; }
        public string Fznr { get; set; }

    }
    
}

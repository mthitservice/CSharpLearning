using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisierung
{ // Kennzeichn das diese Klasse serialisirt werden darf
    [Serializable]
    // Modellklasse(reale Strukturen abbilden) ( ohne Funktionen)
   [System.Xml.Serialization.XmlRoot("Spezialauto")]
    public class Auto
    {
        private float _tankinhalt { get; set; }
        public int Breite { get; set; }
        [System.Xml.Serialization.XmlElement("LNG")]
        public int Laenge { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("Fahrzeugmarke")]
        public string Marke { get; set; }
        [System.Xml.Serialization.XmlAttribute("Fahrzeugnummer")]
       
        public string Fznr { get; set; }

    }
    
}

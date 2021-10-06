
using System;


namespace CSharpGrundlagen.Klassen.Allgemein
{

    public class KlasseAuto
    {
        // Variablen
        public int breite;
        public int laenge;
        // Gekapselte Variable
        private int _tankinhalt;

        // Methoden

        //Konstruktor
        public KlasseAuto()
        {
            Console.WriteLine("Objekt von Klasse Auto erzeugt");
        }
        public KlasseAuto(int Plaenge,int Pbreite)
        {
            breite = Pbreite;
            laenge = Plaenge;
            Console.WriteLine("Objekt von Klasse Auto erzeugt mit länge und breite");
        }

        public void tanken(int liter)
        {
            _tankinhalt = _tankinhalt + liter;
         // Kurzform   _tankinhalt += liter;

        }


        public KlasseAuto(float Plaenge, float Pbreite)
        {
            //breite = Pbreite;
            //laenge = Plaenge;
            Console.WriteLine("Objekt von Klasse Auto erzeugt mit länge und breite als float");
        }
        //Destruktor

        ~KlasseAuto()
        {
            Console.WriteLine("Objekt wird aus dem Speicher entfernt");
            
        }


        public virtual void hupen()
        {
            Console.WriteLine("hupen");
        }

        public override string ToString()
        {
            return String.Format("Auto mit Tankinhalt:{0}", _tankinhalt);
        }

    }


   class KlasseLKW : KlasseAuto
    {
        //Spezialisierung = Vererbung
        public void fahren()
        { }

        public override void hupen()
        {
            base.hupen();
        
        
            Console.WriteLine("starkhupen");
            base.hupen();
        }

    }

 


   public class MeineErsteKlasse
    {
        // Vererbung
        // Polymorphy
        // Kapselung
        // Events
        // Objekt
        // Klasse

        // Modifizierer
        // Variablen
      
        /// <summary>
        /// int , float Wertetypen
        /// </summary>
        int Zahl1;
        float zahl2;
        char Buchstabe;
        /// <summary>
        ///  Deklaration vom System Typ Datetime
        /// </summary>

        DateTime Datum;

        /// <summary>
        /// string, Alle Klassen = Verweistyp
        /// </summary>
        string VariableA; // Deklaration


   
        /// <summary>
        ///  Deklartion meines benutzerdefinierten Datentyps
        /// </summary>
        MeineErsteKlasse MeinObjekt;
        KlasseAuto MeinAuto;

        //Methoden
        // Funktionen und Prozeduren

        void MeineProzedur(int wert)
        {

        }

       public  int MeineFunktion( DateTime wert)
        {
            wert = DateTime.Now;
            return 0;
        }
        public int MeineFunktion(KlasseAuto wert)
        {
            wert.breite = 15; ;
            return 0;
        }









    }
}

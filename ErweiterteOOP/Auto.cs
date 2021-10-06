using System;
using System.Collections.Generic;
using System.Text;

namespace ErweiterteOOP
{
    public delegate void TankHandler(object sender, TankEventArgs e);

    public class KlasseAuto:IAuto,IRadio
    {
      
        // Variablen
        public int breite;
        public int laenge;
        
       

        // Eigenschafent
        private int _hoehe;
        private Farbe _farbe;
        private int _tankinhalt;
        public  event TankHandler Reserve;

        public int Tankinhalt
        {
            get { return _tankinhalt; }
            set {   _tankinhalt = value; }
        }

       

      

      
        public int hoehe
        {
            get { return _hoehe; }
            set { _hoehe = value; }
        }

        public Farbe farbe
        {
            get
            {
                return _farbe;
            }
           set
            {
                 _farbe=value;
            }

        }




        // Gekapselte Variable


        // Methoden
        // Event 


        //Konstruktor
        public KlasseAuto()
        {
            Console.WriteLine("Objekt von Klasse Auto erzeugt");
        }
        public KlasseAuto(int Plaenge, int Pbreite)
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

        public void fahren(int km)
        {
            if (Tankinhalt - km < 3) {
                
               Reserve?.Invoke(this, new TankEventArgs("Nur noch zwei Liter im Tank"));
            }
            Tankinhalt = Tankinhalt - km;

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

        public void hupen(int laustaerke)
        {
            
        }

        public void RadioAn()
        {
          
        }

        public void RadioAus()
        {
           
        }

        public int Lautstaerke()
        {
            return 0;
        }
    }

    public class TankEventArgs : EventArgs
    {
        public TankEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }

}

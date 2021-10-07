using System;
using System.Collections.Generic;
using System.Text;

namespace ErweiterteOOP
{
    public delegate void TankFunktionsstruktur(KlasseAuto sender, TankEventArgs e);

    public class KlasseAuto:IAuto,IRadio
    {
      
        // Variablen
        public int breite;
        public int laenge;
        
       

        // Eigenschafent
        private int _hoehe;
        private Farbe _farbe;
        private int _tankinhalt;
        private int _pin;
        public  event TankFunktionsstruktur Reserve;

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
            _pin = 1234;
            Console.WriteLine("Objekt von Klasse Auto erzeugt");
        }
        public KlasseAuto(int Plaenge, int Pbreite)
        {
            _pin = 1234;
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
                
               Reserve?.Invoke(this, new TankEventArgs("Tank ist weniger als 2 Liter",Tankinhalt-km));
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
        public TankEventArgs(string message,int aktuellerTankinhalt)
        {
                       
            this.Message = message;
            this.aktuellerTankinhalt = aktuellerTankinhalt;

        }

        public string Message { get; set; }
        public int aktuellerTankinhalt { get; set; }
    }

}

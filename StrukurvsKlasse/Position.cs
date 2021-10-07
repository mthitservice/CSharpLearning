using System;
using System.Collections.Generic;
using System.Text;

namespace StrukurvsKlasse
{
   public  class Position
    {//Eine Klasse ist ein Verweistyp
        // ZUgriff auf KLasse
        // Adresse holn
        // -> x und Y lesen

        public int x { get; set; }
        public int y { get; set; }

        public void zeige ()
        {

            Console.WriteLine("Der Wert von x:{0} und y:{1} ", x, y);

        }


    }

    public struct stPosition
    {// EIne Struktur ist ein Wertetyp
        //->wert direkt aus speicher lesen
        public int x { get; set; }
        public int y { get; set; }


    }

}

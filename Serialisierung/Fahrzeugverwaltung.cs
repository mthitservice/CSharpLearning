using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialisierung
{
    // Funktionsklasse (Controller) (Methoden ohne Modelle)
   public  class Fahrzeugverwaltung: IAutoConroller
    {
        // Deklartion von Variablen
       public  List<IFahrzeug> Autoliste;
        //
        AnsichtenConsole ansicht;

        //Konstruktor
        public Fahrzeugverwaltung()
        {
            // Instanziiere
            Autoliste = new List<IFahrzeug>();
            ansicht = new AnsichtenConsole();

        }
        // Methoden
        public void start()
        {
            // 3 Autos hinzufügen
            Auto a1 = new Auto();
            a1.Breite = 16;
            a1.Fznr = "aaaa1";
            a1.Laenge = 30;
            a1.Marke = "Mercedes";
            Autoliste.Add(a1);
            Auto a2 = new Auto();
            a2.Breite = 16;
            a2.Fznr = "aaaa2";
            a2.Laenge = 30;
            a2.Marke = "Fiat";
            Autoliste.Add(a2);
            Auto a3 = new Auto();
            a3.Breite = 16;
            a3.Fznr = "aaaa3";
            a3.Laenge = 30;
            a3.Marke = "Skoda";
            Autoliste.Add(a3);

            // Speichern
            this.speichern(@"c:\temp\autos.xyz");

            // Zeige Fahrzeuge
            this.zeigeFahrzeuge(Autoliste);
            // Warte auf Taste
            ansicht.WartaufTaste();
        }

        public void zeigeFahrzeuge(List<IFahrzeug> Fahrzeuge)
        {
            ansicht.zeigeFahrzeuge(Fahrzeuge);
        }

        void speichern(string pfad)
        {
            // Filestream zum speichern von Dateien öffnen
            Stream fs = File.OpenWrite(pfad);
            // Serialisierungsobjekt
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Autoliste);
            fs.Flush();
            fs.Close();
            fs.Dispose();



        }
    }
}

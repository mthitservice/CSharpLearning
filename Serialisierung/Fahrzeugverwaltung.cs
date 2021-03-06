using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialisierung
{
    // Funktionsklasse (Controller) (Methoden ohne Modelle)
   public  class Fahrzeugverwaltung: IAutoConroller
    {
        // Deklartion von Variablen
       public  List<Auto> Autoliste;
        //
        AnsichtenConsole ansicht;

        //Konstruktor
        public Fahrzeugverwaltung()
        {
            // Instanziiere
            Autoliste = new List<Auto>();
            ansicht = new AnsichtenConsole();

        }
        // Methoden
        public void start()
        {
            // laden(@"c:\temp\autos.xyz");
            // ladenXML(@"c:\temp\autos.xml");
            //ladenJSON(@"c:\temp\autos.json");
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
            // this.speichern(@"c:\temp\autos.xyz");
            // speichernXML(@"c:\temp\autos.xml");
            speichernJSON(@"c:\temp\autos.json");
            // Zeige Fahrzeuge
            this.zeigeFahrzeuge(Autoliste);
            // Warte auf Taste
            ansicht.WartaufTaste();
        }

        public void zeigeFahrzeuge(List<Auto> Fahrzeuge)
        {
            ansicht.zeigeFahrzeuge(Fahrzeuge);
        }

        void speichern(string pfad)
        {
            // Filestream zum speichern von Dateien öffnen
            Stream fs = File.OpenWrite(pfad);
            // Serialisierungsobjekt
            
            // Krypto Serialisierer
            
            // Zip 
            
            BinaryFormatter formatter = new BinaryFormatter();
           
            
            
            formatter.Serialize(fs, Autoliste);
            fs.Flush();
            fs.Close();
            fs.Dispose();



        }
        void ladenJSON(string pfad)
        {
            // Text Laden
           var fs = File.ReadAllText(pfad);
            // Serialisierungsobjekt
            List<Auto> templ;
           templ=(List<Auto>) JsonSerializer.Deserialize<List<Auto>>(fs);
            Autoliste = templ;
       





        }

        void speichernXML(string pfad)
        {
            // Filestream zum speichern von Dateien öffnen
            Stream fs = File.OpenWrite(pfad);
            // Serialisierungsobjekt

            // Krypto Serialisierer

            // Zip 



            XmlSerializer xser = new XmlSerializer(typeof(List<Auto>));
            xser.Serialize(fs, Autoliste);

          
            fs.Flush();
            fs.Close();
            fs.Dispose();



        }

        void speichernJSON(string pfad)
        {



            // Filestream zum speichern von Dateien öffnen
            using (Stream fs = File.OpenWrite(pfad))
            {
                //Komprimierungsstream
                 // Serialisierungsobjekt
                   
                    JsonSerializer.SerializeAsync(fs, Autoliste);
           

                }

          



        }

        void ladenXML(string pfad)
        {
            // Filestream zum Laden von Dateien öffnen
            FileStream fs = File.Open(pfad,FileMode.Open);
            // Serialisierungsobjekt

            // Krypto Serialisierer

            // Zip 

            List<Auto> templ;

            XmlSerializer xser = new XmlSerializer(typeof(List<Auto>));
            templ=(List<Auto>)xser.Deserialize(fs);
            Autoliste = templ;

            fs.Flush();
            fs.Close();
            fs.Dispose();



        }
        void laden(string pfad)
        {
            // Filestream zum speichern von Dateien öffnen
            FileStream fs = File.Open(pfad,FileMode.Open);
            // Serialisierungsobjekt
            BinaryFormatter formatter = new BinaryFormatter();
            List<Auto> templist = (List<Auto>)formatter.Deserialize(fs);


            Autoliste = templist;
           
            fs.Flush();
            fs.Close();
            fs.Dispose();



        }
    }
}

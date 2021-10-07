using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GenerischeKlassen
{
   
    public class Verarbeitung {

        public void test() {

            int d = 1;
            int[] da = { 1, 3,5, 6};
            int[,] dzwei = { { 1, 3 },{ 5, 6 } };
            string[] texte =new string[10];

            texte[5] = "Hallo";
            texte[7] = "Test";



            Console.WriteLine("da 2:{0} ",da[2]);
            Console.WriteLine("text länge:{0} ", texte.Length);

            // Generika

            List<Fahrzeug> fahrzeugliste = new List<Fahrzeug>();

            // Dictonary
            IDictionary<string, Fahrzeug> fzliste = new Dictionary<string, Fahrzeug>();
            



            Auto a1 = new Auto();
            a1.breite = 12;
            a1.laenge = 15;
            a1.Marke = "Skoda";
            a1.fznr = "afznr1";
            Motorad m1 = new Motorad();
            m1.breite = 5;
            m1.laenge = 8;
            m1.Marke = "KTM";
            m1.fznr = "mfznr1";
            fahrzeugliste.Add(a1);
            fahrzeugliste.Add(m1);
            fzliste.Add(a1.fznr, a1);
            fzliste.Add(m1.fznr, m1);
            foreach (var z in fzliste)
            {

                Console.WriteLine("Key:{0},value:{1}", z.Key, z.Value);
            }

            Fahrzeug fm;
            fzliste.TryGetValue("afznr1", out fm);

            Console.WriteLine("gefunden:{0}",(Auto)fm);



                foreach (object x in fahrzeugliste)
            {

                switch (x.GetType().ToString())
                {
                    case "GenerischeKlassen.Auto":
                        Auto y = (Auto)x;
                        y.hupen();
                        Fahrzeug fz = (Fahrzeug)y;
                        List<int> tankinhalt= new List<int>() { 4, 5, 2 };
                        fz.tanken<int>(tankinhalt);


                        break;
                    case "GenerischeKlassen.Motorad":
                        Motorad u = (Motorad)x;
                        u.hupen();
                        Fahrzeug fz1 = (Fahrzeug)u;
                        List<float> tankinhalt1 = new List<float>() { 4, 6, 2 };
                        fz1.tanken<float>(tankinhalt1);
                        break;


                }
                Console.WriteLine("Typ:{0}", x.GetType());

                //  x.hupen();
                // Linq zum abfragen von Arrays und dynamische Typen

                var teet = fahrzeugliste.Where(g => g.Marke == "KTM").ToList();







            }




            
            


        }



    }
}

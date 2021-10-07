using System;
using System.Collections.Generic;
using System.Text;

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
            Auto a1 = new Auto();
            Motorad m1 = new Motorad();
            fahrzeugliste.Add(a1);
            fahrzeugliste.Add(m1);

            foreach (object x in fahrzeugliste)
            {

                switch (x.GetType().ToString())
                {
                    case "GenerischeKlassen.Auto":
                        Auto y = (Auto)x;
                        y.hupen();
                        break;
                    case "GenerischeKlassen.Motorad":
                        Motorad u = (Motorad)x;
                        u.hupen();
                        break;


                }
                Console.WriteLine("Typ:{0}", x.GetType());

              //  x.hupen();

            }




            
            


        }



    }
}

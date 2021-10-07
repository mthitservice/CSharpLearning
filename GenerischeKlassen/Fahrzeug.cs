using System;
using System.Collections.Generic;
using System.Text;

namespace GenerischeKlassen
{
   public class Fahrzeug
    {
        public int laenge { get; set; }
        public int breite { get; set; }
        public string Marke { get; set; }

        public string fznr { get; set; }

        public  void tanken<T>(IList<T> volumen)
        {
            
            foreach (T item in volumen) 
            {
                Console.WriteLine(item.ToString() + " ");

            }

            Console.WriteLine();
        }

    }
}

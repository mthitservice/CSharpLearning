using System;

namespace ErweiterteOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum benutzen
            Dokumentstatus ds;
            ds = Dokumentstatus.abgeschlossen;

            // Schnittstelle benutzen

            KlasseAuto auto = new KlasseAuto();
            auto.Tankinhalt = 4;
            auto.hoehe = 5;
            auto.breite = 4;
            auto.Reserve += xas;
          
            
            IAuto HupController = auto;
            IRadio RadioController = auto;
            HupController.hupen(4);
            auto.fahren(3);
            RadioController.RadioAn();




            Console.WriteLine("Dokstaus:{0}",Convert.ToInt32(ds));



            Console.WriteLine("Hello World!");
        }

        private static void xas(KlasseAuto sender, TankEventArgs e)
        {
           Console.WriteLine("Event"+ sender);

        }

      



     
    }
}

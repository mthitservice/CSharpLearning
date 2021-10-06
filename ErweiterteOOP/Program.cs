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
            auto.Reserve += Auto_Reserve;
          
            
            IAuto HupController = auto;
            IRadio RadioController = auto;
            HupController.hupen(4);
            auto.fahren(3);
            RadioController.RadioAn();




            Console.WriteLine("Dokstaus:{0}",Convert.ToInt32(ds));



            Console.WriteLine("Hello World!");
        }



        private static void Auto_Reserve(object sender,TankEventArgs e)
        {
            Console.WriteLine(e.Message);
        }



     
    }
}

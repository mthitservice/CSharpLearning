using CSharpGrundlagen.Klassen.Allgemein;
using System;

namespace CSharpGrundlagen
{
    #region "Meine erste Klasse"
    class Program
    {
        static void Main(string[]data)
        {
#if DEBUG
            System.Console.WriteLine("Hello World! Debug");
            MeineErsteKlasse mk = new MeineErsteKlasse();
            DateTime a=DateTime.MinValue;

            Console.WriteLine("vor Funktionsaufruf {0}", a);
            
            KlasseAuto ObjektAuto    ; ///Deklaration der Struktur
            ObjektAuto= new KlasseAuto(4,5);// Instanziierung
            ObjektAuto.tanken(5);
            Console.WriteLine("Autoinfos: {0}", ObjektAuto);
            ObjektAuto.tanken(2);
            Console.WriteLine("Autoinfos: {0}", ObjektAuto);
            KlasseLKW ObjektLKW;
            ObjektLKW = new KlasseLKW();

            ObjektAuto.hupen();
            ObjektLKW.hupen();



            Console.WriteLine("vor Funktionsaufruf {0}", ObjektAuto.breite);

            mk.MeineFunktion(ObjektAuto);

            Console.WriteLine("nach Funktionsaufruf {0}", ObjektAuto.breite);

            ObjektAuto = null;
           
           



            Console.ReadKey();


#else
        System.Console.WriteLine("Hello World! Release");
#endif
        }
    }


#endregion
}

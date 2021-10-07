using System;

namespace StrukurvsKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Position po = new Position();
            po.x = 100;
            po.y = 200;
            po.zeige();


            stPosition st = new stPosition();
            st.x = 100;
            st.y = 200;


            Console.WriteLine("Hello World!");
        }
    }
}

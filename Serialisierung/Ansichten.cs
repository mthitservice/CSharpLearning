using System;
using System.Collections.Generic;
using System.Text;

namespace Serialisierung
{
    public class AnsichtenConsole : IAutoConroller
    {
        public void zeigeFahrzeuge(List<IFahrzeug> Fahrzeuge)
        {
            foreach (var o in Fahrzeuge)
            {
                Console.WriteLine(o);
               

            }
        }

        public void WartaufTaste()
        {
            Console.ReadKey();

        }
    }
}

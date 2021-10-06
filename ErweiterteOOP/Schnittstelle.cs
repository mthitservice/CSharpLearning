using System;
using System.Collections.Generic;
using System.Text;

namespace ErweiterteOOP
{
   public  interface IAuto
    {
        Farbe farbe { get; set; }
        

        void hupen(int laustaerke);
    }
    public interface IRadio
    {
        void RadioAn();
        void RadioAus();

        int Lautstaerke();
    }
}

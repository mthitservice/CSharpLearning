using System;
using System.Collections.Generic;
using System.Text;

namespace SQLFensterAnwendung
{
   public class IPInfo
    {
        public DateTime TestDate { get; set; }
        public string ip { get; set; }
        public long ttl { get; set; }

        public int TestPort { get; set; }
        public bool portchechk { get; set; }

       public IPInfo    ()

        {
            TestDate = DateTime.Now;

        }

        public override string ToString()
        {
            return String.Format("{0}-{1} \t\tTestport:{2}\t Ergebnis:{3}\t TTL:{4}", TestDate, ip, TestPort, portchechk,ttl);
        }
    }
}

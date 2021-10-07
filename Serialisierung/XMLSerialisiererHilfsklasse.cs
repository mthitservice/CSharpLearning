using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Serialisierung
{
 public   class XMLSerialisiererHilfsklasseIFahrzeuge:IXmlSerializable
    {
        public IFahrzeug Fahrzeug  {get; set; }



        public XMLSerialisiererHilfsklasseIFahrzeuge()
        { }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("Fahrzeug ");
            string strType = reader.GetAttribute("type");
            XmlSerializer serial = new XmlSerializer(Type.GetType(strType));
            Fahrzeug = (IFahrzeug)serial.Deserialize(reader);
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Child");
            string strType = Fahrzeug.GetType().FullName;
            writer.WriteAttributeString("type", strType);
            XmlSerializer serial = new XmlSerializer(Type.GetType(strType));
            serial.Serialize(writer, Fahrzeug);
            writer.WriteEndElement();
        }
    }
}

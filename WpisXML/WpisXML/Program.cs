using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpisXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateXml();
        }

        static private void CreateXml()
        {
            XmlTextWriter writer = new XmlTextWriter("Osoba.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("osoba");
            CreateNode("imie", "Mateusz", writer);
            CreateNode("nazwisko", "Rus", writer);
            CreateNode("zawod", "Programista", writer);
            CreateNode("hobby", "Siatkowka", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            Console.WriteLine("Plik XML został stworzony!");
        }

        static private void CreateNode(string tag, string value, XmlTextWriter writer)
        {
            writer.WriteStartElement(tag);
            writer.WriteString(value);
            writer.WriteEndElement();
        }
    }
}

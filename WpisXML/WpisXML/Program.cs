using System;
using System.Xml;

namespace WpisXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadXml();
        }

        static private void ReadXml()
        {
            XmlTextReader reader = new XmlTextReader("Osoba.xml");
            reader.Read();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<{0}>" , reader.Name);
                        break;
                    case XmlNodeType.Text:
                        Console.Write(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</{0}>", reader.Name);
                        break;
                }
            }

                Console.ReadLine();
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

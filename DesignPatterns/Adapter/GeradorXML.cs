using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    public class GeradorXML
    {
        public string Gerar(Object objeto)
        {
            XmlSerializer serializer = new XmlSerializer(objeto.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, objeto);

            return writer.ToString();
        }
    }
}

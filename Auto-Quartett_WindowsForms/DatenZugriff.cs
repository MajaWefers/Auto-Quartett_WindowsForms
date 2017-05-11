using System.IO;
using System.Xml.Serialization;

namespace Auto_Quartett_WindowsForms
{
    public class DatenZugriff
    {
        private readonly XmlSerializer xmlSerializer;
        private readonly string dateiPfad;

        public DatenZugriff(string dateiPfad)
        {
            this.dateiPfad = dateiPfad;
            this.xmlSerializer = new XmlSerializer(typeof(Autokarte[]), new XmlRootAttribute("Autokarten"));
        }

        public Autokarte[] LadeKarten()
        {
            using (var reader = new StreamReader(this.dateiPfad))
            {
                return (Autokarte[]) this.xmlSerializer.Deserialize(reader);
            }
        }
    }
}

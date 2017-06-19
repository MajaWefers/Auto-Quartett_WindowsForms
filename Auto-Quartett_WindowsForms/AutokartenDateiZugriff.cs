using System.IO;
using System.Xml.Serialization;

namespace Auto_Quartett_WindowsForms
{
    /// <summary>
    /// Beinhaltet Logik zum Laden und Speichern von Arrays von <see cref="Autokarte"/>n
    /// in einer XML-Datei.
    /// Der Pfad der Datei wird bei der Erstellung eines Objekts dieser Klasse festgelegt.
    /// </summary>
    public class AutokartenDateiZugriff
    {
        private readonly XmlSerializer xmlSerializer;
        private readonly string dateiPfad;

        /// <summary>
        /// <see cref="dateiPfad"/> kann sowohl ein absoluter als auch ein relativer Pfad ausgehend vom Ort des
        /// ausgeführten Programms sein.
        /// </summary>
        /// <param name="dateiPfad"></param>
        public AutokartenDateiZugriff(string dateiPfad)
        {
            this.dateiPfad = dateiPfad;
            this.xmlSerializer = new XmlSerializer(typeof(Autokarte[]), new XmlRootAttribute("Autokarten"));
        }

        /// <summary>
        /// Lädt die beim Erstellen dieses Objekts festgelegte XML-Datei
        /// und deserialisiert den Inhalt zu einem Array <see cref="Autokarte"/>n.
        /// </summary>
        /// <returns></returns>
        public Autokarte[] LadeKarten()
        {
            //using entsorgt den StreamReader nach Ausführung der umschlossenen Anweisungen
            //und gibt damit die Datei frei
            using (var reader = new StreamReader(this.dateiPfad))
            {
                return (Autokarte[]) this.xmlSerializer.Deserialize(reader);
            }
        }

        /// <summary>
        /// Speichert das übergebene Array als XML in die beim Erstellen dieses Objekts
        /// festgelegte Datei. Der Inhalt der Datei wird dabei vollständig überschrieben.
        /// </summary>
        /// <param name="karten"></param>
        public void SpeichereKarten(Autokarte[] karten)
        {
            using (var streamWriter= new StreamWriter(this.dateiPfad))
            {
                this.xmlSerializer.Serialize(streamWriter, karten);
            }
        }
    }
}

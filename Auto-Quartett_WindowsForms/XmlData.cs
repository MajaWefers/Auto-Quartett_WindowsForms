using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Auto_Quartett_WindowsForms
{
    public class XmlSave
    {
        public static void SaveData(object IClass, string filename)
        {

            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(IClass.GetType());
                writer= new StreamWriter(filename);
                xmlSerializer.Serialize(writer, IClass);
                
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
        }

    }

    public class XmlLoad<T>
    {
        public static Type type;
        public XmlLoad()
        {
            type = typeof(T);
        }
        public T LoadData(string filename)
        {
            T result;
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            result = (T)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            return result;
        }
    }
}

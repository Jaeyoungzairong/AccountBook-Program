using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace AccountBookProgram
{
    public class XmlManager<T>
    {
        public Type m_Type;

        public XmlManager()
        {
            m_Type = typeof(T);
        }

        public void Save(string path, object obj)
        {
            using (TextWriter textWriter = new StreamWriter(path))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(m_Type);
                    serializer.Serialize(textWriter, obj);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                textWriter.Close();
            }

        }

        public T Read(string path)
        {
            T result = default(T);
            using (TextReader textReader = new StreamReader(path))
            {
                try
                {
                    XmlSerializer deserializer = new XmlSerializer(m_Type);
                    result = (T)deserializer.Deserialize(textReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                textReader.Close();
            }
            return result;
        }
    }
}

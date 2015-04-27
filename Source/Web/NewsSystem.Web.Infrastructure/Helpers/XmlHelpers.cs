using NewsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewsSystem.Web.Infrastructure.Helpers
{
    public class XmlHelpers
    {
        public static T DeserializeXml<T>(string xmlRoot) where T:class
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            object deserializedObject;
            using (StreamReader reader = new StreamReader(xmlRoot))
            {
                deserializedObject = s.Deserialize(reader);
                
            }

            return deserializedObject as T;
        }
    }
}

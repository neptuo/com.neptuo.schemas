using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Schemas.Models
{
    public class SchemaDataService
    {
        public const string DataUri = "~/App_Data/Schemas.xml";

        private IEnumerable<Xsd> models;

        public SchemaDataService(string dataUri)
        {
            using (StreamReader reader = new StreamReader(dataUri))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SchemaList));
                models = (SchemaList)serializer.Deserialize(reader);
            }
        }

        public IEnumerable<Xsd> Get()
        {
            return models;
        }
    }
}
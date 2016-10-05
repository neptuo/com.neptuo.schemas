using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Schemas.Models
{
    [XmlRoot("Schemas")]
    public class SchemaList : List<Xsd>
    {
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Schemas.Models
{
    [XmlType("Xsd")]
    [XmlRoot("Xsd")]
    public class Xsd
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public string DocumentationUrl { get; set; }
    }
}
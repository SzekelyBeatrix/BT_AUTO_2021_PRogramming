using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.PageModels.APIModels
{
    [XmlRoot(ElementName = "route")]
    class MapQuestRequestModel
    {
        [XmlArray(ElementName = "locations")]
        [XmlArrayItem(ElementName = "locations")]
        public List<string> locations { get; set; }

        [XmlArray(ElementName = "options")]
        public MapQuestOptionsModel options { get; set; }
    }
}

using AdapterPattern.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern {
    public class JsonConverter : IJsonConverter {

        public string ConvertToJson(string xml) {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonResult = JsonConvert.SerializeXmlNode(doc);
            return jsonResult;
        }
    }
}

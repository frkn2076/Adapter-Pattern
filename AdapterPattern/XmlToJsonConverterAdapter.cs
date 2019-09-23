using AdapterPattern.Interfaces;

namespace AdapterPattern {
    public class XmlToJsonConverterAdapter : SourceXml, ISourceXml {
        private IJsonConverter jsonConverter;

        public XmlToJsonConverterAdapter(IJsonConverter jsonConverter) {
            this.jsonConverter = jsonConverter;
        }

        public string GetData() {
            var xmlData = base.GetData();
            var resData = jsonConverter.ConvertToJson(xmlData);
            return resData;
        }
    }
}

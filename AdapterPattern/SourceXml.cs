using AdapterPattern.Interfaces;

namespace AdapterPattern {
    public class SourceXml : ISourceXml {
        public string GetData()
        {
            string xmlData = @"<note>
    <to>Tove</to>
    <from>Jani</from>
    <heading>Reminder</heading>
    <body>Don't forget me this weekend!</body>
</note>";
            return xmlData;
        }
    }
}

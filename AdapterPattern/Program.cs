using System;

namespace AdapterPattern {
    public class Program
    {
        static void Main(string[] args) {

            var myService = new MyService();

            // Before Adapter Pattern

            var sourceXml = new SourceXml();
            var myXmlData = sourceXml.GetData();
            myService.PrintData(myXmlData);


            // After Adapter Pattern

            var jsonConverter = new JsonConverter();
            var xmlToJsonAdapter = new XmlToJsonConverterAdapter(jsonConverter);
            var myConvertedToJsonData = xmlToJsonAdapter.GetData();
            myService.PrintData(myConvertedToJsonData);

            Console.ReadKey();
        }
    }
}

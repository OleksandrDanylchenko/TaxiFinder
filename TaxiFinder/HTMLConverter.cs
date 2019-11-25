using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TaxiFinder
{
    internal class HTMLConverter
    {
        private readonly List<Taxi> _outputTaxis;
        private readonly string _filePath;

        public HTMLConverter(List<(string service, List<Taxi> foundedTaxis)> results, SaveFileDialog saveDialog)
        {
            _outputTaxis = new List<Taxi>();
            foreach (var (service, foundedTaxis) in results)
            {
                _outputTaxis.AddRange(foundedTaxis);
            }

            _filePath = saveDialog.FileName;
        }

        public void Convert()
        {
            if(_outputTaxis.Count != 0)
            {
                ExtractResultsInXML();
            }
        }

        private void ExtractResultsInXML()
        {
            string xmlFilePath = _filePath.Replace(".html", ".xml");
            FileStream fs = new FileStream(xmlFilePath, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(_outputTaxis.GetType(), new XmlRootAttribute("taxis"));
            //StreamWriter writer = new StreamWriter(xmlFilePath);
            serializer.Serialize(fs, _outputTaxis);
        }
    }
}

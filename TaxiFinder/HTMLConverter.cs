using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace TaxiFinder
{
    internal class HTMLConverter
    {
        private readonly List<Taxi> _outputTaxis;
        private readonly TaxiFinderForm _form;

        public HTMLConverter(IEnumerable<(string service, List<Taxi> foundedTaxis)> results, TaxiFinderForm form)
        {
            _outputTaxis = new List<Taxi>();
            foreach (var (_, foundedTaxis) in results)
            {
                _outputTaxis.AddRange(foundedTaxis);
            }

            _form = form;
        }

        public void Convert()
        {
            if (_outputTaxis.Count != 0 && _form.HTMLSaveDialog.ShowDialog() == DialogResult.OK)
            {
                string htmlPath = _form.HTMLSaveDialog.FileName;
                string xmlPath = ExtractResultsInTempXML(htmlPath);

                TransformWithTemplate(xmlPath, htmlPath);
                RemoveTempXML(xmlPath);
            }
        }

        private string ExtractResultsInTempXML(string htmlPath)
        {
            string xmlFilePath = htmlPath.Replace(".html", ".xml");

            FileStream fs = new FileStream(xmlFilePath, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(_outputTaxis.GetType(), new XmlRootAttribute("Taxis"));
            serializer.Serialize(fs, _outputTaxis);
            fs.Close();

            return xmlFilePath;
        }

        private static void TransformWithTemplate(string xmlPath, string htmlPath)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(typeof(HTMLTransform));
            xslt.Transform(xmlPath, htmlPath);
        }

        private static void RemoveTempXML(string xmlPath)
        {
            File.Delete(xmlPath);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace TaxiFinder
{
    // Context
    internal class SearchEngine
    {
        private readonly Taxi _desiredTaxi;
        private readonly ISearchEngineStrategy _engine;

        public SearchEngine(Taxi desiredTaxi, ISearchEngineStrategy engine)
        {
            _desiredTaxi = desiredTaxi;
            _engine = engine;
        }

        public List<(string service, List<Taxi> foundedTaxis)> ScanAllFiles()
        {
            var results = new List<(string, List<Taxi>)>();

            var filesPaths = FilesProvider.GetInstance.FilesPaths;
            var servicesNames = FilesProvider.GetInstance.ServicesNames;

            for (var i = 0; i < filesPaths.Length; ++i)
            {
                var serviceName = servicesNames[i];
                var filePath = filesPaths[i];
                var foundedTaxisInService = _engine.DoSearchInFile(filePath, _desiredTaxi);

                results.Add((serviceName, foundedTaxisInService));
            }

            return results;
        }
    }

    // Strategy
    internal interface ISearchEngineStrategy
    {
        List<Taxi> DoSearchInFile(string filePath, Taxi desiredTaxi);
    }

    // Concrete Strategy A
    internal class EngineDOM : ISearchEngineStrategy
    {
        public List<Taxi> DoSearchInFile(string filePath, Taxi desiredTaxi)
        {
            var foundedTaxis = new List<Taxi>();

            var xDoc = new XmlDocument();
            xDoc.Load(filePath);
            var xRoot = xDoc.DocumentElement;

            var taxiNodes = xRoot?.SelectNodes("Taxi");
            if (taxiNodes != null)
            {
                foreach (XmlElement taxi in taxiNodes)
                {
                    var newTaxi = new Taxi();

                    foreach (XmlElement element in taxi)
                    {
                        if (element.Name == "Brand" && (string.IsNullOrWhiteSpace(desiredTaxi.Brand) ||
                                                        ElementsComparer.IsEqual(element.InnerText, 
                                                            desiredTaxi.Brand)))
                        {
                            newTaxi.Brand = element.InnerText;
                        }

                        else if (element.Name == "Model" && (string.IsNullOrWhiteSpace(desiredTaxi.Model) ||
                                                             element.InnerText.ToUpper()
                                                                 .Contains(desiredTaxi.Model.ToUpper())))
                        {
                            newTaxi.Model = element.InnerText;
                        }

                        else if (element.Name == "Color" && (string.IsNullOrWhiteSpace(desiredTaxi.Color) ||
                                                             ElementsComparer.IsEqual(element.InnerText, 
                                                                 desiredTaxi.Color)))
                        {
                            newTaxi.Color = element.InnerText;
                        }

                        else if (element.Name == "Class" && (string.IsNullOrWhiteSpace(desiredTaxi.Class) ||
                                                             ElementsComparer.IsEqual(element.InnerText, 
                                                                 desiredTaxi.Class)))
                        {
                            newTaxi.Class = element.InnerText;
                        }

                        else if (element.Name == "Driver" && (string.IsNullOrWhiteSpace(desiredTaxi.Driver) ||
                                                              ElementsComparer.IsEqual(element.InnerText, 
                                                                  desiredTaxi.Driver)))
                        {
                            newTaxi.Driver = element.InnerText;
                        }

                        else if (element.Name == "Number" && (string.IsNullOrWhiteSpace(desiredTaxi.Number) ||
                                                              element.InnerText.ToUpper()
                                                                  .Contains(desiredTaxi.Number.ToUpper())))
                        {
                            newTaxi.Number = element.InnerText;
                        }
                    }

                    if (newTaxi.IsFieldsInitialized())
                    {
                        foundedTaxis.Add(newTaxi);
                    }
                }
            }

            return foundedTaxis;
        }
    }

    // Concrete Strategy B
    internal class EngineSAX : ISearchEngineStrategy
    {
        public List<Taxi> DoSearchInFile(string filePath, Taxi desiredTaxi)
        {
            var foundedTaxis = new List<Taxi>();
            using (var xr = XmlReader.Create(filePath))
            {
                var iteratorTaxi = new Taxi();

                var element = string.Empty;
                while (xr.Read())
                {
                    // Reads the element
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        element = xr.Name; // The name of the current element
                    }
                    // Reads the element value
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (element == "Brand" && (string.IsNullOrWhiteSpace(desiredTaxi.Brand) ||
                                                   ElementsComparer.IsEqual(xr.Value, 
                                                       desiredTaxi.Brand)))
                        {
                            iteratorTaxi.Brand = xr.Value;
                        }
                        else if (element == "Model" && (string.IsNullOrWhiteSpace(desiredTaxi.Model) || 
                                                        xr.Value.ToUpper()
                                                            .Contains(desiredTaxi.Model.ToUpper())))
                        {
                            iteratorTaxi.Model = xr.Value;
                        }

                        else if (element == "Color" && (string.IsNullOrWhiteSpace(desiredTaxi.Color) ||
                                                        ElementsComparer.IsEqual(xr.Value, 
                                                            desiredTaxi.Color)))
                        {
                            iteratorTaxi.Color = xr.Value;
                        }

                        else if (element == "Class" && (string.IsNullOrWhiteSpace(desiredTaxi.Class) ||
                                                        ElementsComparer.IsEqual(xr.Value, 
                                                            desiredTaxi.Class)))
                        {
                            iteratorTaxi.Class = xr.Value;
                        }

                        else if (element == "Driver" && (string.IsNullOrWhiteSpace(desiredTaxi.Driver) ||
                                                         ElementsComparer.IsEqual(xr.Value, 
                                                             desiredTaxi.Driver)))
                        {
                            iteratorTaxi.Driver = xr.Value;
                        }

                        else if (element == "Number" && (string.IsNullOrWhiteSpace(desiredTaxi.Number) ||
                                                         xr.Value.ToUpper()
                                                             .Contains(desiredTaxi.Number.ToUpper())))
                        {
                            iteratorTaxi.Number = xr.Value;
                        }
                    }

                    // Reads the closing element
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "Taxi"))
                    {
                        if (iteratorTaxi.IsFieldsInitialized())
                        {
                            var newTaxi = iteratorTaxi;
                            foundedTaxis.Add(newTaxi);
                            iteratorTaxi = new Taxi();
                        }
                    }
                }
            }
            return foundedTaxis;
        }
    }

    // Concrete Strategy C
    internal class EngineLinq : ISearchEngineStrategy
    {
        public List<Taxi> DoSearchInFile(string filePath, Taxi desiredTaxi)
        {
            var xdoc = XDocument.Load(filePath);
            var foundedElements = from elem in xdoc.Element("Taxis")?.Elements("Taxi")
                where
                    (string.IsNullOrWhiteSpace(desiredTaxi.Brand) ||
                     ElementsComparer.IsEqual(elem.Element("Brand")?.Value, desiredTaxi.Brand)) &&

                    (string.IsNullOrWhiteSpace(desiredTaxi.Model) ||
                     elem.Element("Model").Value.ToUpper().Contains(desiredTaxi.Model.ToUpper())) &&

                    (string.IsNullOrWhiteSpace(desiredTaxi.Color) ||
                     ElementsComparer.IsEqual(elem.Element("Color")?.Value, desiredTaxi.Color)) &&

                    (string.IsNullOrWhiteSpace(desiredTaxi.Class) ||
                     ElementsComparer.IsEqual(elem.Element("Class")?.Value, desiredTaxi.Class)) &&

                    (string.IsNullOrWhiteSpace(desiredTaxi.Driver) ||
                     ElementsComparer.IsEqual(elem.Element("Driver")?.Value, desiredTaxi.Driver)) &&

                    (string.IsNullOrWhiteSpace(desiredTaxi.Number) ||
                     ElementsComparer.IsEqual(elem.Element("Number")?.Value, desiredTaxi.Number))

                select new Taxi
                {
                    Brand = elem.Element("Brand")?.Value.ToString(),
                    Model = elem.Element("Model")?.Value.ToString(),
                    Color = elem.Element("Color")?.Value.ToString(),
                    Class = elem.Element("Class")?.Value.ToString(),
                    Driver = elem.Element("Driver")?.Value.ToString(),
                    Number = elem.Element("Number")?.Value.ToString()
                };

            return foundedElements.ToList();
        }
    }
}
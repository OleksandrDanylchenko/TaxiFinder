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
            List<(string, List<Taxi>)> results = new List<(string, List<Taxi>)>();

            string[] filesPaths = FilesProvider.GetInstance.FilesPaths;
            string[] servicesNames = FilesProvider.GetInstance.ServicesNames;

            for (int i = 0; i < filesPaths.Length; ++i)
            {
                string serviceName = servicesNames[i];
                string filePath = filesPaths[i];
                List<Taxi> foundedTaxisInService = _engine.DoSearchInFile(filePath, _desiredTaxi);

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
            List<Taxi> foundedTaxis = new List<Taxi>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNodeList taxiNodes = xRoot?.SelectNodes("taxi");
            if (taxiNodes != null)
            {
                foreach (XmlElement taxi in taxiNodes)
                {
                    string brand = string.Empty;
                    string model = string.Empty;
                    string color = string.Empty;
                    string @class = string.Empty;
                    string driver = string.Empty;
                    string number = string.Empty;

                    foreach (XmlElement element in taxi)
                    {
                        if (element.Name == "brand" && (desiredTaxi.Brand == string.Empty ||
                                                        ElementsComparer.IsEqual(element.InnerText,
                                                            desiredTaxi.Brand)))
                        {
                            brand = element.InnerText;
                        }

                        else if (element.Name == "model" && (desiredTaxi.Model == string.Empty || 
                                                             element.InnerText.ToUpper().Contains(desiredTaxi.Model.ToUpper())))
                        {
                            model = element.InnerText;
                        }

                        else if (element.Name == "color" && (desiredTaxi.Color == string.Empty ||
                                                             ElementsComparer.IsEqual(element.InnerText,
                                                                 desiredTaxi.Color)))
                        {
                            color = element.InnerText;
                        }

                        else if (element.Name == "class" && (desiredTaxi.Class == string.Empty ||
                                                             ElementsComparer.IsEqual(element.InnerText,
                                                                 desiredTaxi.Class)))
                        {
                            @class = element.InnerText;
                        }

                        else if (element.Name == "driver" && (desiredTaxi.Driver == string.Empty ||
                                                              ElementsComparer.IsEqual(element.InnerText,
                                                                  desiredTaxi.Driver)))
                        {
                            driver = element.InnerText;
                        }

                        else if (element.Name == "number" && (desiredTaxi.Number == string.Empty ||
                                                              ElementsComparer.IsEqual(element.InnerText,
                                                                  desiredTaxi.Number)))
                        {
                            number = element.InnerText;
                        }
                    }

                    if (brand != string.Empty && model != string.Empty && color != string.Empty &&
                        @class != string.Empty && driver != string.Empty && number != string.Empty)
                    {
                        Taxi foundedTaxi = new Taxi(brand, model, color, @class, driver, number);
                        foundedTaxis.Add(foundedTaxi);
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
            List<Taxi> foundedTaxis = new List<Taxi>();

            using (XmlReader xr = XmlReader.Create(filePath))
            {
                string brand = string.Empty;
                string model = string.Empty;
                string color = string.Empty;
                string @class = string.Empty;
                string driver = string.Empty;
                string number = string.Empty;

                string element = string.Empty;

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
                        if (element == "brand" && (desiredTaxi.Brand == string.Empty ||
                                                   ElementsComparer.IsEqual(xr.Value,
                                                       desiredTaxi.Brand)))
                        {
                            brand = xr.Value;
                        }

                        else if (element == "model" && (desiredTaxi.Model == string.Empty || 
                                                        xr.Value.ToUpper().Contains(desiredTaxi.Model.ToUpper())))
                        {
                            model = xr.Value;
                        }

                        else if (element == "color" && (desiredTaxi.Color == string.Empty ||
                                                        ElementsComparer.IsEqual(xr.Value,
                                                            desiredTaxi.Color)))
                        {
                            color = xr.Value;
                        }

                        else if (element == "class" && (desiredTaxi.Class == string.Empty ||
                                                        ElementsComparer.IsEqual(xr.Value,
                                                            desiredTaxi.Class)))
                        {
                            @class = xr.Value;
                        }

                        else if (element == "driver" && (desiredTaxi.Driver == string.Empty ||
                                                         ElementsComparer.IsEqual(xr.Value,
                                                             desiredTaxi.Driver)))
                        {
                            driver = xr.Value;
                        }

                        else if (element == "number" && (desiredTaxi.Number == string.Empty ||
                                                         ElementsComparer.IsEqual(xr.Value,
                                                             desiredTaxi.Number)))
                        {
                            number = xr.Value;
                        }
                    }

                    // Reads the closing element
                    else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "taxi"))
                    {
                        if (brand != string.Empty && model != string.Empty && color != string.Empty &&
                            @class != string.Empty && driver != string.Empty && number != string.Empty)
                        {
                            Taxi foundedTaxi = new Taxi(brand, model, color, @class, driver, number);
                            foundedTaxis.Add(foundedTaxi);

                            brand = model = color = @class = driver = number = string.Empty;
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
            XDocument xdoc = XDocument.Load(filePath);
            var foundedElements = from elem in xdoc.Element("taxis")?.Elements("taxi")
                                  where 
                                   (desiredTaxi.Brand == string.Empty ||
                                    ElementsComparer.IsEqual(elem.Element("brand")?.Value.ToString(),
                                        desiredTaxi.Brand)) &&
                                   (desiredTaxi.Model == string.Empty ||
                                    elem.Element("model").Value.ToUpper().Contains(desiredTaxi.Model.ToUpper())) &&
                                   (desiredTaxi.Color == string.Empty ||
                                    ElementsComparer.IsEqual(elem.Element("color")?.Value.ToString(),
                                        desiredTaxi.Color)) &&
                                   (desiredTaxi.Class == string.Empty ||
                                    ElementsComparer.IsEqual(elem.Element("class")?.Value.ToString(),
                                        desiredTaxi.Class)) &&
                                   (desiredTaxi.Driver == string.Empty ||
                                    ElementsComparer.IsEqual(elem.Element("driver")?.Value.ToString(),
                                        desiredTaxi.Driver)) &&
                                   (desiredTaxi.Number == string.Empty ||
                                    ElementsComparer.IsEqual(elem.Element("number")?.Value.ToString(),
                                        desiredTaxi.Number))
                                  select new
                                  {
                                      brand = elem.Element("brand")?.Value.ToString(),
                                      model = elem.Element("model")?.Value.ToString(),
                                      color = elem.Element("color")?.Value.ToString(),
                                      @class = elem.Element("class")?.Value.ToString(),
                                      driver = elem.Element("driver")?.Value.ToString(),
                                      number = elem.Element("number")?.Value.ToString()
                                  };

            return foundedElements
                .Select(fe => new Taxi(fe.brand, fe.model, fe.color, fe.@class, fe.driver, fe.number))
                .ToList();
        }
    }
}
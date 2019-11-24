using System;
using System.Collections.Generic;
using System.Xml;

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
                List<Taxi> foundedTaxisInService = _engine.DoSearchInFile(filesPaths[i], _desiredTaxi);

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
                    string Class = string.Empty;
                    string driver = string.Empty;
                    string number = string.Empty;

                    foreach (XmlElement element in taxi)
                    {
                        if ((element.Name == "brand" && element.InnerText == desiredTaxi.Brand) ||
                            desiredTaxi.Brand == string.Empty)
                        {
                            brand = element.InnerText;
                        }

                        if ((element.Name == "model" && element.InnerText == desiredTaxi.Model) ||
                            desiredTaxi.Model == string.Empty)
                        {
                            model = element.InnerText;
                        }

                        if ((element.Name == "color" && element.InnerText == desiredTaxi.Color) ||
                            desiredTaxi.Color == string.Empty)
                        {
                            color = element.InnerText;
                        }
                        
                        if ((element.Name == "class" && element.InnerText == desiredTaxi.Class) ||
                            desiredTaxi.Class == string.Empty)
                        {
                            Class = element.InnerText;
                        }

                        if ((element.Name == "driver" && element.InnerText == desiredTaxi.Driver) ||
                            desiredTaxi.Driver == string.Empty)
                        {
                            driver = element.InnerText;
                        }

                        if ((element.Name == "number" && element.InnerText == desiredTaxi.Number) ||
                            desiredTaxi.Number == string.Empty)
                        {
                            number = element.InnerText;
                        }
                    }

                    if (brand != string.Empty && model != string.Empty && color != string.Empty &&
                        Class != string.Empty && driver != string.Empty && number != string.Empty)
                    {
                        Taxi foundedTaxi = new Taxi(brand, model, color, Class, driver, number);
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
            throw new NotImplementedException();
        }
    }

    // Concrete Strategy C
    internal class EngineLinq : ISearchEngineStrategy
    {
        public List<Taxi> DoSearchInFile(string filePath, Taxi desiredTaxi)
        {
            throw new NotImplementedException();
        }
    }
}

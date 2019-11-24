using System.Collections.Generic;

namespace TaxiFinder
{
    internal static class Searcher
    {
        public static List<(string service, List<Taxi> foundedTaxis)> ExecuteSearch(TaxiFinderForm form)
        {
            Taxi desiredTaxi = CreateSearchRequest(form);
            ISearchEngineStrategy engineStrategy = GetSearchEngine(form);
            if (desiredTaxi == null || engineStrategy == null)
            {
                return new List<(string, List<Taxi>)>();
            }

            SearchEngine executiveEngine = new SearchEngine(desiredTaxi, engineStrategy);
            List<(string, List<Taxi>)> results = executiveEngine.ScanAllFiles();

            return results;
        }

        private static Taxi CreateSearchRequest(TaxiFinderForm form)
        {
            string brand = string.Empty;
            string model = string.Empty;
            string color = string.Empty;
            string @class = string.Empty;
            string driver = string.Empty;
            string number = string.Empty;

            if (form.BrandCheck.Checked)
            {
                brand = form.BrandBox.Text;
            }

            if (form.ModelCheck.Checked)
            {
                model = form.ModelBox.Text;
            }

            if (form.ColorCheck.Checked)
            {
                color = form.ColorBox.Text;
            }

            if (form.ClassCheck.Checked)
            {
                @class = form.ClassBox.Text;
            }

            if (form.DriverCheck.Checked)
            {
                driver = form.DriverBox.Text;
            }

            if (form.NumberCheck.Checked)
            {
                number = form.NumberBox.Text;
            }

            if (brand == string.Empty && model == string.Empty && color == string.Empty &&
                @class == string.Empty && driver == string.Empty && number == string.Empty)
            {
                return null;
            }

            return new Taxi(brand, model, color, @class, driver, number);
        }

        private static ISearchEngineStrategy GetSearchEngine(TaxiFinderForm form)
        {
            ISearchEngineStrategy searchEngine = null;

            if (form.DomButton.Checked)
            {
                searchEngine = new EngineDOM();
            }

            if (form.SaxButton.Checked)
            {
                searchEngine = new EngineSAX();
            }

            if (form.LinqButton.Checked)
            {
                searchEngine = new EngineLinq();
            }

            return searchEngine;
        }
    }
}
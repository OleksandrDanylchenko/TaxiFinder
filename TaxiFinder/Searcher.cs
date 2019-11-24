using System.Collections.Generic;

namespace TaxiFinder
{
    internal static class Searcher
    {
        public static List<(string service, List<Taxi> foundedTaxis)> ExecuteSearch(TaxiFinderForm form)
        {
            Taxi desiredTaxi = CreateSearchRequest(form);

            ISearchEngineStrategy engineStrategy = GetSearchEngine(form);
            if (engineStrategy == null)
            {
                return new List<(string, List<Taxi>)>();
            }

            SearchEngine executiveEngine = new SearchEngine(desiredTaxi, engineStrategy);
            List<(string, List<Taxi>)> results = executiveEngine.ScanAllFiles();

            return results;
        }

        private static Taxi CreateSearchRequest(TaxiFinderForm form)
        {
            Taxi desiredTaxi = new Taxi();

            if (form.BrandCheck.Checked)
            {
                desiredTaxi.Brand = form.BrandBox.Text;
            }

            if (form.ModelCheck.Checked)
            {
                desiredTaxi.Model = form.ModelBox.Text;
            }

            if (form.ColorCheck.Checked)
            {
                desiredTaxi.Color = form.ColorBox.Text;
            }

            if (form.ClassCheck.Checked)
            {
                desiredTaxi.Class = form.ClassBox.Text;
            }

            if (form.DriverCheck.Checked)
            {
                desiredTaxi.Driver = form.DriverBox.Text;
            }

            if (form.NumberCheck.Checked)
            {
                desiredTaxi.Number = form.NumberBox.Text;
            }

            return desiredTaxi;
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
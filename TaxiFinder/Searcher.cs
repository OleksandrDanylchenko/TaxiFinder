using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal static class Searcher
    {
        public static List<(string service, List<Taxi> foundedTaxis)> ExecuteSearch(TaxiFinderForm form)
        {
            var desiredTaxi = CreateSearchRequest(form);
            var engineStrategy = GetSearchEngine(form);
            if (desiredTaxi == null || engineStrategy == null)
            {
                return new List<(string, List<Taxi>)>();
            }

            var executiveEngine = new SearchEngine(desiredTaxi, engineStrategy);

            try
            {
                List<(string, List<Taxi>)> results = executiveEngine.ScanAllFiles();
                return results;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error occurred while reading an input XML file." +
                                "Try to reload data XML files.",
                    "XML file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<(string, List<Taxi>)>();
            }
        }

        private static Taxi CreateSearchRequest(TaxiFinderForm form)
        {
            var desiredTaxi = new Taxi();

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

            return desiredTaxi.IsFieldsBlank() ? null : desiredTaxi;
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
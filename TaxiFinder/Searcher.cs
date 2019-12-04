using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal class Searcher
    {
        private readonly TaxiFinderForm _form;
        public Searcher(TaxiFinderForm form)
        {
            _form = form;
        }

        public List<(string service, List<Taxi> foundedTaxis)> ExecuteSearch()
        {
            var desiredTaxi = CreateSearchRequest();
            var engineStrategy = GetSearchEngine();
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

        private Taxi CreateSearchRequest()
        {
            var desiredTaxi = new Taxi();

            if (_form.BrandCheck.Checked)
            {
                desiredTaxi.Brand = _form.BrandBox.Text;
            }

            if (_form.ModelCheck.Checked)
            {
                desiredTaxi.Model = _form.ModelBox.Text;
            }

            if (_form.ColorCheck.Checked)
            {
                desiredTaxi.Color = _form.ColorBox.Text;
            }

            if (_form.ClassCheck.Checked)
            {
                desiredTaxi.Class = _form.ClassBox.Text;
            }

            if (_form.DriverCheck.Checked)
            {
                desiredTaxi.Driver = _form.DriverBox.Text;
            }

            if (_form.NumberCheck.Checked)
            {
                desiredTaxi.Number = _form.NumberBox.Text;
            }

            return desiredTaxi.IsAllFieldsBlank() ? null : desiredTaxi;
        }

        private ISearchEngineStrategy GetSearchEngine()
        {
            ISearchEngineStrategy searchEngine = null;

            if (_form.DomButton.Checked)
            {
                searchEngine = new EngineDOM();
            }

            if (_form.SaxButton.Checked)
            {
                searchEngine = new EngineSAX();
            }

            if (_form.LinqButton.Checked)
            {
                searchEngine = new EngineLinq();
            }

            return searchEngine;
        }
    }
}
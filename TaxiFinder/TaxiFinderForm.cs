using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxiFinder
{
    public partial class TaxiFinderForm : Form
    {
        private List<(string service, List<Taxi> foundedTaxis)> _results = new List<(string, List<Taxi>)>();

        public TaxiFinderForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _results = Searcher.ExecuteSearch(this);
            ResultsPrinter.Print(_results, ResultsBox);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultsBox.Text = string.Empty;
            _results.Clear();
        }

        private void ConvertToHTMLButton_Click(object sender, EventArgs e)
        {
            var converter = new HTMLConverter(_results, this);
            converter.Convert();
        }

        private void BrandCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Brand search filter. Click on label to activate it.",
                "BrandCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModelCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Model search filter. Click on label to activate it.",
                "ModelCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColorCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Color search filter. Click on label to activate it.",
                "ColorCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClassCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Class search filter. Click on label to activate it.",
                "ClassCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DriverCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Driver search filter. Click on label to activate it.",
                "DriverCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NumberCheck_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Number search filter. Click on label to activate it.",
                "NumberCheck help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DomButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to engage DOM API search engine.",
                "DOM API help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaxButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to engage SAX API search engine.",
                "SAX API help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LinqButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to engage Linq to XML search engine.",
                "Linq to XML help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to start searching with one of three possible search engines",
                "Search help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to clear results box",
                "Clear help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConvertToHTMLButton_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Click on label to create HTML file from results of searches",
                "HTML convert help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BrandBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the brand of desired car to create filter",
                "BrandBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ModelBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the model of desired car to create filter",
                "ModelBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColorBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the color of desired car to create filter",
                "ColorBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClassBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the class of desired car to create filter",
                "ClassBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DriverBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the driver full name of desired car to create filter",
                "DriverBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NumberBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Type the plate number of desired car to create filter",
                "NumberBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResultsBox_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("This field can output results of searching through XML files.",
                "ResultBox help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
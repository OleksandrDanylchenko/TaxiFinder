using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal static class ResultsPrinter
    {
        public static void Print(List<(string service, List<Taxi> foundedTaxis)> results, RichTextBox resultsBox)
        {
            resultsBox.Text = string.Empty;
            foreach (var (service, foundedTaxis) in results)
            {
                resultsBox.AppendText($"{service}:\n");
                foreach (var taxi in foundedTaxis)
                {
                    string taxiOutput = $"Brand: {taxi.Brand}\n" +
                                        $"Model: {taxi.Model}\n" +
                                        $"Color: {taxi.Color}\n" +
                                        $"Class {taxi.Class}\n" +
                                        $"Driver {taxi.Driver}\n" +
                                        $"Number {taxi.Number}\n" +
                                        "--------------\n";
                    resultsBox.AppendText(taxiOutput);
                }
            }
        }
    }
}

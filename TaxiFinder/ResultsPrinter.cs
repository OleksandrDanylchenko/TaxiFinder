using System.Collections.Generic;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal static class ResultsPrinter
    {
        public static void Print(List<(string service, List<Taxi> foundedTaxis)> results,
                                 RichTextBox resultsBox)
        {
            resultsBox.Text = string.Empty;
            foreach (var (service, foundedTaxis) in results)
            {
                resultsBox.AppendText($"\n{service}:\n");

                int num = 1;
                foreach (var taxi in foundedTaxis)
                {
                    var taxiOutput = $"{num}:\n" +
                                     $"  Brand: {taxi.Brand}\n" +
                                     $"  Model: {taxi.Model}\n" +
                                     $"  Color: {taxi.Color}\n" +
                                     $"  Class {taxi.Class}\n" +
                                     $"  Driver {taxi.Driver}\n" +
                                     $"  Number {taxi.Number}\n";
                    resultsBox.AppendText(taxiOutput);
                    ++num;
                }
            }
        }
    }
}

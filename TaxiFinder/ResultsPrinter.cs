using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal static class ResultsPrinter
    {
        public static void Print(IEnumerable<(string service, List<Taxi> foundedTaxis)> results,
                                 RichTextBox resultsBox)
        {
            resultsBox.Text = string.Empty;
            foreach (var (service, foundedTaxis) in results)
            {
                resultsBox.AppendText($"\n{service}:\n");

                var outputNumber = 1;
                foreach (var taxiOutput in foundedTaxis
                    .Select(taxi => $"{outputNumber}:\n" +
                                    $"  Brand: {taxi.Brand}\n" +
                                    $"  Model: {taxi.Model}\n" +
                                    $"  Color: {taxi.Color}\n" +
                                    $"  Class {taxi.Class}\n" +
                                    $"  Driver {taxi.Driver}\n" +
                                    $"  Number {taxi.Number}\n"))
                {
                    resultsBox.AppendText(taxiOutput);
                    ++outputNumber;
                }
            }
        }
    }
}
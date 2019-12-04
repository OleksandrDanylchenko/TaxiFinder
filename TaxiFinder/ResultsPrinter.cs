using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaxiFinder
{
    internal class ResultsPrinter
    {
        private readonly RichTextBox _outputBox;
        public ResultsPrinter(RichTextBox outputBox)
        {
            _outputBox = outputBox;
        }

        public void Print(IEnumerable<(string service, List<Taxi> foundedTaxis)> results)
        {
            _outputBox.Text = string.Empty;
            foreach (var (service, foundedTaxis) in results)
            {
                _outputBox.AppendText($"\n{service}:\n");

                var outputNumber = 1;
                foreach (var taxiOutput in foundedTaxis
                    .Select(taxi => $"{outputNumber}:\n" +
                                    $"  Brand: {taxi.Brand}\n" +
                                    $"  Model: {taxi.Model}\n" +
                                    $"  Color: {taxi.Color}\n" +
                                    $"  Class: {taxi.Class}\n" +
                                    $"  Driver: {taxi.Driver}\n" +
                                    $"  Number: {taxi.Number}\n"))
                {
                    _outputBox.AppendText(taxiOutput);
                    ++outputNumber;
                }
            }
        }
    }
}
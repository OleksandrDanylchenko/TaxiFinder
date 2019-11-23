using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiFinder
{
    public partial class TaxiFinder : Form
    {

        public TaxiFinder()
        {
            InitializeComponent();
            var a = FilesProvider.GetInstance.FilesPaths;
            var b = FilesProvider.GetInstance.FilesNames;
            ResultsBox.Text = "Alexander Danylchenko";
            return;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BrandCheck.Checked = false;
            BrandBox.Text = string.Empty;

            ModelCheck.Checked = false;
            ModelBox.Text = string.Empty;

            ColorCheck.Checked = false;
            ColorBox.Text = string.Empty;

            DriverCheck.Checked = false;
            DriverBox.Text = string.Empty;

            NumberCheck.Checked = false;
            NumberBox.Text = string.Empty;

            ResultsBox.Text = string.Empty;
        }

        private void ConvertToHTMLButton_Click(object sender, EventArgs e)
        {

        }
    }
}

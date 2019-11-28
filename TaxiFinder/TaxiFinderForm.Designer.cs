namespace TaxiFinder
{
    partial class TaxiFinderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxiFinderForm));
            this.ClearButton = new System.Windows.Forms.Button();
            this.ConvertToHTMLButton = new System.Windows.Forms.Button();
            this.BrandCheck = new System.Windows.Forms.CheckBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ModelCheck = new System.Windows.Forms.CheckBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.ColorCheck = new System.Windows.Forms.CheckBox();
            this.DriverBox = new System.Windows.Forms.TextBox();
            this.DriverCheck = new System.Windows.Forms.CheckBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.NumberCheck = new System.Windows.Forms.CheckBox();
            this.DomButton = new System.Windows.Forms.RadioButton();
            this.SaxButton = new System.Windows.Forms.RadioButton();
            this.LinqButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.ClassCheck = new System.Windows.Forms.CheckBox();
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.HTMLSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.AutoEllipsis = true;
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClearButton_HelpRequested);
            // 
            // ConvertToHTMLButton
            // 
            resources.ApplyResources(this.ConvertToHTMLButton, "ConvertToHTMLButton");
            this.ConvertToHTMLButton.Name = "ConvertToHTMLButton";
            this.ConvertToHTMLButton.UseVisualStyleBackColor = true;
            this.ConvertToHTMLButton.Click += new System.EventHandler(this.ConvertToHTMLButton_Click);
            this.ConvertToHTMLButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ConvertToHTMLButton_HelpRequested);
            // 
            // BrandCheck
            // 
            resources.ApplyResources(this.BrandCheck, "BrandCheck");
            this.BrandCheck.Name = "BrandCheck";
            this.BrandCheck.UseVisualStyleBackColor = true;
            this.BrandCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.BrandCheck_HelpRequested);
            // 
            // BrandBox
            // 
            this.BrandBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("BrandBox.AutoCompleteCustomSource"),
            resources.GetString("BrandBox.AutoCompleteCustomSource1"),
            resources.GetString("BrandBox.AutoCompleteCustomSource2"),
            resources.GetString("BrandBox.AutoCompleteCustomSource3"),
            resources.GetString("BrandBox.AutoCompleteCustomSource4"),
            resources.GetString("BrandBox.AutoCompleteCustomSource5"),
            resources.GetString("BrandBox.AutoCompleteCustomSource6"),
            resources.GetString("BrandBox.AutoCompleteCustomSource7"),
            resources.GetString("BrandBox.AutoCompleteCustomSource8"),
            resources.GetString("BrandBox.AutoCompleteCustomSource9"),
            resources.GetString("BrandBox.AutoCompleteCustomSource10"),
            resources.GetString("BrandBox.AutoCompleteCustomSource11"),
            resources.GetString("BrandBox.AutoCompleteCustomSource12"),
            resources.GetString("BrandBox.AutoCompleteCustomSource13"),
            resources.GetString("BrandBox.AutoCompleteCustomSource14"),
            resources.GetString("BrandBox.AutoCompleteCustomSource15"),
            resources.GetString("BrandBox.AutoCompleteCustomSource16"),
            resources.GetString("BrandBox.AutoCompleteCustomSource17"),
            resources.GetString("BrandBox.AutoCompleteCustomSource18"),
            resources.GetString("BrandBox.AutoCompleteCustomSource19"),
            resources.GetString("BrandBox.AutoCompleteCustomSource20"),
            resources.GetString("BrandBox.AutoCompleteCustomSource21"),
            resources.GetString("BrandBox.AutoCompleteCustomSource22"),
            resources.GetString("BrandBox.AutoCompleteCustomSource23"),
            resources.GetString("BrandBox.AutoCompleteCustomSource24"),
            resources.GetString("BrandBox.AutoCompleteCustomSource25"),
            resources.GetString("BrandBox.AutoCompleteCustomSource26"),
            resources.GetString("BrandBox.AutoCompleteCustomSource27"),
            resources.GetString("BrandBox.AutoCompleteCustomSource28"),
            resources.GetString("BrandBox.AutoCompleteCustomSource29"),
            resources.GetString("BrandBox.AutoCompleteCustomSource30"),
            resources.GetString("BrandBox.AutoCompleteCustomSource31"),
            resources.GetString("BrandBox.AutoCompleteCustomSource32"),
            resources.GetString("BrandBox.AutoCompleteCustomSource33"),
            resources.GetString("BrandBox.AutoCompleteCustomSource34"),
            resources.GetString("BrandBox.AutoCompleteCustomSource35"),
            resources.GetString("BrandBox.AutoCompleteCustomSource36"),
            resources.GetString("BrandBox.AutoCompleteCustomSource37"),
            resources.GetString("BrandBox.AutoCompleteCustomSource38"),
            resources.GetString("BrandBox.AutoCompleteCustomSource39"),
            resources.GetString("BrandBox.AutoCompleteCustomSource40"),
            resources.GetString("BrandBox.AutoCompleteCustomSource41"),
            resources.GetString("BrandBox.AutoCompleteCustomSource42"),
            resources.GetString("BrandBox.AutoCompleteCustomSource43"),
            resources.GetString("BrandBox.AutoCompleteCustomSource44"),
            resources.GetString("BrandBox.AutoCompleteCustomSource45"),
            resources.GetString("BrandBox.AutoCompleteCustomSource46"),
            resources.GetString("BrandBox.AutoCompleteCustomSource47"),
            resources.GetString("BrandBox.AutoCompleteCustomSource48"),
            resources.GetString("BrandBox.AutoCompleteCustomSource49"),
            resources.GetString("BrandBox.AutoCompleteCustomSource50")});
            this.BrandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BrandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BrandBox.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.BrandBox, "BrandBox");
            this.BrandBox.ForeColor = System.Drawing.Color.Black;
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.BrandBox_HelpRequested);
            // 
            // ModelBox
            // 
            this.ModelBox.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.ModelBox, "ModelBox");
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ModelBox_HelpRequested);
            // 
            // ModelCheck
            // 
            resources.ApplyResources(this.ModelCheck, "ModelCheck");
            this.ModelCheck.Name = "ModelCheck";
            this.ModelCheck.UseVisualStyleBackColor = true;
            this.ModelCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ModelCheck_HelpRequested);
            // 
            // ColorBox
            // 
            this.ColorBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("ColorBox.AutoCompleteCustomSource"),
            resources.GetString("ColorBox.AutoCompleteCustomSource1"),
            resources.GetString("ColorBox.AutoCompleteCustomSource2"),
            resources.GetString("ColorBox.AutoCompleteCustomSource3"),
            resources.GetString("ColorBox.AutoCompleteCustomSource4"),
            resources.GetString("ColorBox.AutoCompleteCustomSource5"),
            resources.GetString("ColorBox.AutoCompleteCustomSource6"),
            resources.GetString("ColorBox.AutoCompleteCustomSource7"),
            resources.GetString("ColorBox.AutoCompleteCustomSource8"),
            resources.GetString("ColorBox.AutoCompleteCustomSource9"),
            resources.GetString("ColorBox.AutoCompleteCustomSource10"),
            resources.GetString("ColorBox.AutoCompleteCustomSource11"),
            resources.GetString("ColorBox.AutoCompleteCustomSource12"),
            resources.GetString("ColorBox.AutoCompleteCustomSource13"),
            resources.GetString("ColorBox.AutoCompleteCustomSource14"),
            resources.GetString("ColorBox.AutoCompleteCustomSource15"),
            resources.GetString("ColorBox.AutoCompleteCustomSource16"),
            resources.GetString("ColorBox.AutoCompleteCustomSource17"),
            resources.GetString("ColorBox.AutoCompleteCustomSource18"),
            resources.GetString("ColorBox.AutoCompleteCustomSource19"),
            resources.GetString("ColorBox.AutoCompleteCustomSource20"),
            resources.GetString("ColorBox.AutoCompleteCustomSource21"),
            resources.GetString("ColorBox.AutoCompleteCustomSource22")});
            this.ColorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColorBox.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.ColorBox, "ColorBox");
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ColorBox_HelpRequested);
            // 
            // ColorCheck
            // 
            resources.ApplyResources(this.ColorCheck, "ColorCheck");
            this.ColorCheck.Name = "ColorCheck";
            this.ColorCheck.UseVisualStyleBackColor = true;
            this.ColorCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ColorCheck_HelpRequested);
            // 
            // DriverBox
            // 
            this.DriverBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DriverBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DriverBox.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.DriverBox, "DriverBox");
            this.DriverBox.Name = "DriverBox";
            this.DriverBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DriverBox_HelpRequested);
            // 
            // DriverCheck
            // 
            resources.ApplyResources(this.DriverCheck, "DriverCheck");
            this.DriverCheck.Name = "DriverCheck";
            this.DriverCheck.UseVisualStyleBackColor = true;
            this.DriverCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DriverCheck_HelpRequested);
            // 
            // NumberBox
            // 
            this.NumberBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("NumberBox.AutoCompleteCustomSource"),
            resources.GetString("NumberBox.AutoCompleteCustomSource1"),
            resources.GetString("NumberBox.AutoCompleteCustomSource2"),
            resources.GetString("NumberBox.AutoCompleteCustomSource3"),
            resources.GetString("NumberBox.AutoCompleteCustomSource4"),
            resources.GetString("NumberBox.AutoCompleteCustomSource5"),
            resources.GetString("NumberBox.AutoCompleteCustomSource6"),
            resources.GetString("NumberBox.AutoCompleteCustomSource7"),
            resources.GetString("NumberBox.AutoCompleteCustomSource8"),
            resources.GetString("NumberBox.AutoCompleteCustomSource9"),
            resources.GetString("NumberBox.AutoCompleteCustomSource10"),
            resources.GetString("NumberBox.AutoCompleteCustomSource11"),
            resources.GetString("NumberBox.AutoCompleteCustomSource12"),
            resources.GetString("NumberBox.AutoCompleteCustomSource13"),
            resources.GetString("NumberBox.AutoCompleteCustomSource14"),
            resources.GetString("NumberBox.AutoCompleteCustomSource15"),
            resources.GetString("NumberBox.AutoCompleteCustomSource16"),
            resources.GetString("NumberBox.AutoCompleteCustomSource17"),
            resources.GetString("NumberBox.AutoCompleteCustomSource18"),
            resources.GetString("NumberBox.AutoCompleteCustomSource19"),
            resources.GetString("NumberBox.AutoCompleteCustomSource20"),
            resources.GetString("NumberBox.AutoCompleteCustomSource21"),
            resources.GetString("NumberBox.AutoCompleteCustomSource22"),
            resources.GetString("NumberBox.AutoCompleteCustomSource23"),
            resources.GetString("NumberBox.AutoCompleteCustomSource24"),
            resources.GetString("NumberBox.AutoCompleteCustomSource25"),
            resources.GetString("NumberBox.AutoCompleteCustomSource26"),
            resources.GetString("NumberBox.AutoCompleteCustomSource27"),
            resources.GetString("NumberBox.AutoCompleteCustomSource28"),
            resources.GetString("NumberBox.AutoCompleteCustomSource29"),
            resources.GetString("NumberBox.AutoCompleteCustomSource30"),
            resources.GetString("NumberBox.AutoCompleteCustomSource31"),
            resources.GetString("NumberBox.AutoCompleteCustomSource32"),
            resources.GetString("NumberBox.AutoCompleteCustomSource33"),
            resources.GetString("NumberBox.AutoCompleteCustomSource34"),
            resources.GetString("NumberBox.AutoCompleteCustomSource35"),
            resources.GetString("NumberBox.AutoCompleteCustomSource36"),
            resources.GetString("NumberBox.AutoCompleteCustomSource37"),
            resources.GetString("NumberBox.AutoCompleteCustomSource38"),
            resources.GetString("NumberBox.AutoCompleteCustomSource39"),
            resources.GetString("NumberBox.AutoCompleteCustomSource40"),
            resources.GetString("NumberBox.AutoCompleteCustomSource41"),
            resources.GetString("NumberBox.AutoCompleteCustomSource42"),
            resources.GetString("NumberBox.AutoCompleteCustomSource43"),
            resources.GetString("NumberBox.AutoCompleteCustomSource44"),
            resources.GetString("NumberBox.AutoCompleteCustomSource45"),
            resources.GetString("NumberBox.AutoCompleteCustomSource46"),
            resources.GetString("NumberBox.AutoCompleteCustomSource47"),
            resources.GetString("NumberBox.AutoCompleteCustomSource48"),
            resources.GetString("NumberBox.AutoCompleteCustomSource49"),
            resources.GetString("NumberBox.AutoCompleteCustomSource50"),
            resources.GetString("NumberBox.AutoCompleteCustomSource51"),
            resources.GetString("NumberBox.AutoCompleteCustomSource52"),
            resources.GetString("NumberBox.AutoCompleteCustomSource53"),
            resources.GetString("NumberBox.AutoCompleteCustomSource54"),
            resources.GetString("NumberBox.AutoCompleteCustomSource55"),
            resources.GetString("NumberBox.AutoCompleteCustomSource56"),
            resources.GetString("NumberBox.AutoCompleteCustomSource57"),
            resources.GetString("NumberBox.AutoCompleteCustomSource58")});
            this.NumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NumberBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NumberBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.NumberBox, "NumberBox");
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NumberBox_HelpRequested);
            // 
            // NumberCheck
            // 
            resources.ApplyResources(this.NumberCheck, "NumberCheck");
            this.NumberCheck.Name = "NumberCheck";
            this.NumberCheck.UseVisualStyleBackColor = true;
            this.NumberCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NumberCheck_HelpRequested);
            // 
            // DomButton
            // 
            resources.ApplyResources(this.DomButton, "DomButton");
            this.DomButton.Name = "DomButton";
            this.DomButton.TabStop = true;
            this.DomButton.UseVisualStyleBackColor = true;
            this.DomButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DomButton_HelpRequested);
            // 
            // SaxButton
            // 
            resources.ApplyResources(this.SaxButton, "SaxButton");
            this.SaxButton.Name = "SaxButton";
            this.SaxButton.TabStop = true;
            this.SaxButton.UseVisualStyleBackColor = true;
            this.SaxButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SaxButton_HelpRequested);
            // 
            // LinqButton
            // 
            resources.ApplyResources(this.LinqButton, "LinqButton");
            this.LinqButton.Name = "LinqButton";
            this.LinqButton.TabStop = true;
            this.LinqButton.UseVisualStyleBackColor = true;
            this.LinqButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.LinqButton_HelpRequested);
            // 
            // SearchButton
            // 
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SearchButton_HelpRequested);
            // 
            // ClassBox
            // 
            this.ClassBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("ClassBox.AutoCompleteCustomSource"),
            resources.GetString("ClassBox.AutoCompleteCustomSource1"),
            resources.GetString("ClassBox.AutoCompleteCustomSource2"),
            resources.GetString("ClassBox.AutoCompleteCustomSource3")});
            this.ClassBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ClassBox.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.ClassBox, "ClassBox");
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClassBox_HelpRequested);
            // 
            // ClassCheck
            // 
            resources.ApplyResources(this.ClassCheck, "ClassCheck");
            this.ClassCheck.Name = "ClassCheck";
            this.ClassCheck.UseVisualStyleBackColor = true;
            this.ClassCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClassCheck_HelpRequested);
            // 
            // ResultsBox
            // 
            this.ResultsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.ResultsBox, "ResultsBox");
            this.ResultsBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ResultsBox_HelpRequested);
            // 
            // HTMLSaveDialog
            // 
            this.HTMLSaveDialog.FileName = "ResultHTML";
            resources.ApplyResources(this.HTMLSaveDialog, "HTMLSaveDialog");
            // 
            // TaxiFinderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.ClassCheck);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LinqButton);
            this.Controls.Add(this.SaxButton);
            this.Controls.Add(this.DomButton);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.NumberCheck);
            this.Controls.Add(this.DriverBox);
            this.Controls.Add(this.DriverCheck);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorCheck);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelCheck);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.BrandCheck);
            this.Controls.Add(this.ConvertToHTMLButton);
            this.Controls.Add(this.ClearButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxiFinderForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearButton;
        internal System.Windows.Forms.Button ConvertToHTMLButton;
        internal System.Windows.Forms.CheckBox BrandCheck;
        internal System.Windows.Forms.TextBox ModelBox;
        internal System.Windows.Forms.CheckBox ModelCheck;
        internal System.Windows.Forms.TextBox ColorBox;
        internal System.Windows.Forms.CheckBox ColorCheck;
        internal System.Windows.Forms.TextBox DriverBox;
        internal System.Windows.Forms.CheckBox DriverCheck;
        internal System.Windows.Forms.TextBox NumberBox;
        internal System.Windows.Forms.CheckBox NumberCheck;
        internal System.Windows.Forms.TextBox BrandBox;
        internal System.Windows.Forms.RadioButton DomButton;
        internal System.Windows.Forms.RadioButton SaxButton;
        internal System.Windows.Forms.RadioButton LinqButton;
        internal System.Windows.Forms.Button SearchButton;
        internal System.Windows.Forms.TextBox ClassBox;
        internal System.Windows.Forms.CheckBox ClassCheck;
        internal System.Windows.Forms.RichTextBox ResultsBox;
        public System.Windows.Forms.SaveFileDialog HTMLSaveDialog;
    }
}


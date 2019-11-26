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
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(542, 904);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(194, 55);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClearButton_HelpRequested);
            // 
            // ConvertToHTMLButton
            // 
            this.ConvertToHTMLButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertToHTMLButton.Location = new System.Drawing.Point(742, 904);
            this.ConvertToHTMLButton.Name = "ConvertToHTMLButton";
            this.ConvertToHTMLButton.Size = new System.Drawing.Size(323, 55);
            this.ConvertToHTMLButton.TabIndex = 2;
            this.ConvertToHTMLButton.Text = "Convert to HTML";
            this.ConvertToHTMLButton.UseVisualStyleBackColor = true;
            this.ConvertToHTMLButton.Click += new System.EventHandler(this.ConvertToHTMLButton_Click);
            this.ConvertToHTMLButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ConvertToHTMLButton_HelpRequested);
            // 
            // BrandCheck
            // 
            this.BrandCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.BrandCheck.AutoSize = true;
            this.BrandCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandCheck.Location = new System.Drawing.Point(13, 248);
            this.BrandCheck.Name = "BrandCheck";
            this.BrandCheck.Size = new System.Drawing.Size(128, 39);
            this.BrandCheck.TabIndex = 3;
            this.BrandCheck.Text = " Brand:";
            this.BrandCheck.UseVisualStyleBackColor = true;
            this.BrandCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.BrandCheck_HelpRequested);
            // 
            // BrandBox
            // 
            this.BrandBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Acura",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Skoda",
            "Bentley",
            "BMW",
            "Bugatti",
            "Buick",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "Geely",
            "General Motors",
            "GMC",
            "Honda",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "Kia",
            "Jeep",
            "Koenigsegg",
            "Lamborghini",
            "Land Rover",
            "Lexus",
            "Maserati",
            "Mazda",
            "McLaren",
            "Mercedes",
            "Mini",
            "Mitsubishi",
            "Nissan",
            "Pagani",
            "Peugeot",
            "Porsche",
            "Ram",
            "Renault",
            "Rolls Royce",
            "Saab",
            "Subaru",
            "Suzuki",
            "Tata Motors",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.BrandBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BrandBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.BrandBox.BackColor = System.Drawing.SystemColors.Menu;
            this.BrandBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandBox.ForeColor = System.Drawing.Color.Black;
            this.BrandBox.Location = new System.Drawing.Point(148, 251);
            this.BrandBox.MaxLength = 12;
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(392, 35);
            this.BrandBox.TabIndex = 4;
            this.BrandBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.BrandBox_HelpRequested);
            // 
            // ModelBox
            // 
            this.ModelBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ModelBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBox.Location = new System.Drawing.Point(148, 307);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(392, 35);
            this.ModelBox.TabIndex = 6;
            this.ModelBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ModelBox_HelpRequested);
            // 
            // ModelCheck
            // 
            this.ModelCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModelCheck.AutoSize = true;
            this.ModelCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelCheck.Location = new System.Drawing.Point(13, 304);
            this.ModelCheck.Name = "ModelCheck";
            this.ModelCheck.Size = new System.Drawing.Size(128, 39);
            this.ModelCheck.TabIndex = 5;
            this.ModelCheck.Text = " Model:";
            this.ModelCheck.UseVisualStyleBackColor = true;
            this.ModelCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ModelCheck_HelpRequested);
            // 
            // ColorBox
            // 
            this.ColorBox.AutoCompleteCustomSource.AddRange(new string[] {
            "White",
            "Silver",
            "Gray",
            "Black",
            "Red",
            "Maroon",
            "Yellow",
            "Olive",
            "Lime",
            "Green",
            "Aqua",
            "Teal",
            "Blue",
            "Navy",
            "Fuchsia",
            "Purple",
            "Brown",
            "Silver",
            "Asphalt",
            "Dark Blue",
            "Dark Gray",
            "Dark Green",
            "Gold"});
            this.ColorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ColorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColorBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ColorBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBox.Location = new System.Drawing.Point(148, 365);
            this.ColorBox.MaxLength = 10;
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(392, 35);
            this.ColorBox.TabIndex = 8;
            this.ColorBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ColorBox_HelpRequested);
            // 
            // ColorCheck
            // 
            this.ColorCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorCheck.AutoSize = true;
            this.ColorCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorCheck.Location = new System.Drawing.Point(13, 362);
            this.ColorCheck.Name = "ColorCheck";
            this.ColorCheck.Size = new System.Drawing.Size(128, 39);
            this.ColorCheck.TabIndex = 7;
            this.ColorCheck.Text = " Color:";
            this.ColorCheck.UseVisualStyleBackColor = true;
            this.ColorCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ColorCheck_HelpRequested);
            // 
            // DriverBox
            // 
            this.DriverBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DriverBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DriverBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DriverBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverBox.Location = new System.Drawing.Point(148, 476);
            this.DriverBox.Name = "DriverBox";
            this.DriverBox.Size = new System.Drawing.Size(392, 35);
            this.DriverBox.TabIndex = 10;
            this.DriverBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DriverBox_HelpRequested);
            // 
            // DriverCheck
            // 
            this.DriverCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.DriverCheck.AutoSize = true;
            this.DriverCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverCheck.Location = new System.Drawing.Point(13, 473);
            this.DriverCheck.Name = "DriverCheck";
            this.DriverCheck.Size = new System.Drawing.Size(128, 39);
            this.DriverCheck.TabIndex = 9;
            this.DriverCheck.Text = "Driver:";
            this.DriverCheck.UseVisualStyleBackColor = true;
            this.DriverCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DriverCheck_HelpRequested);
            // 
            // NumberBox
            // 
            this.NumberBox.AutoCompleteCustomSource.AddRange(new string[] {
            "AA",
            "KA",
            "AB",
            "KB",
            "AC",
            "KC",
            "AE",
            "KE",
            "AH",
            "KH",
            "AI",
            "KI",
            "AK",
            "KK",
            "AM",
            "KM",
            "AO",
            "KO",
            "AP",
            "KP",
            "AT",
            "KT",
            "AX",
            "KX",
            "BA",
            "HA",
            "BB",
            "HB",
            "BC",
            "HC",
            "BE",
            "HE",
            "BH",
            "HH",
            "BI",
            "HI",
            "BK",
            "HK",
            "BM",
            "HM",
            "BO",
            "HO",
            "BP",
            "HP",
            "BT",
            "HT",
            "BT",
            "HT",
            "BX",
            "HX",
            "CA",
            "IA",
            "CB",
            "IB",
            "CE",
            "IE",
            "CH",
            "IH",
            "II"});
            this.NumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NumberBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NumberBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NumberBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(148, 528);
            this.NumberBox.MaxLength = 8;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(392, 35);
            this.NumberBox.TabIndex = 12;
            this.NumberBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NumberBox_HelpRequested);
            // 
            // NumberCheck
            // 
            this.NumberCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.NumberCheck.AutoSize = true;
            this.NumberCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberCheck.Location = new System.Drawing.Point(13, 525);
            this.NumberCheck.Name = "NumberCheck";
            this.NumberCheck.Size = new System.Drawing.Size(128, 39);
            this.NumberCheck.TabIndex = 11;
            this.NumberCheck.Text = "Number:";
            this.NumberCheck.UseVisualStyleBackColor = true;
            this.NumberCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.NumberCheck_HelpRequested);
            // 
            // DomButton
            // 
            this.DomButton.AutoSize = true;
            this.DomButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomButton.Location = new System.Drawing.Point(13, 602);
            this.DomButton.Name = "DomButton";
            this.DomButton.Size = new System.Drawing.Size(139, 33);
            this.DomButton.TabIndex = 13;
            this.DomButton.TabStop = true;
            this.DomButton.Text = "DOM API";
            this.DomButton.UseVisualStyleBackColor = true;
            this.DomButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DomButton_HelpRequested);
            // 
            // SaxButton
            // 
            this.SaxButton.AutoSize = true;
            this.SaxButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaxButton.Location = new System.Drawing.Point(176, 602);
            this.SaxButton.Name = "SaxButton";
            this.SaxButton.Size = new System.Drawing.Size(139, 33);
            this.SaxButton.TabIndex = 14;
            this.SaxButton.TabStop = true;
            this.SaxButton.Text = "SAX API";
            this.SaxButton.UseVisualStyleBackColor = true;
            this.SaxButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SaxButton_HelpRequested);
            // 
            // LinqButton
            // 
            this.LinqButton.AutoSize = true;
            this.LinqButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinqButton.Location = new System.Drawing.Point(340, 602);
            this.LinqButton.Name = "LinqButton";
            this.LinqButton.Size = new System.Drawing.Size(199, 33);
            this.LinqButton.TabIndex = 15;
            this.LinqButton.TabStop = true;
            this.LinqButton.Text = "Linq to XML";
            this.LinqButton.UseVisualStyleBackColor = true;
            this.LinqButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.LinqButton_HelpRequested);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(13, 651);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(525, 55);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SearchButton_HelpRequested);
            // 
            // ClassBox
            // 
            this.ClassBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Econom",
            "Standart",
            "Business",
            "Premium"});
            this.ClassBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ClassBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClassBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBox.Location = new System.Drawing.Point(148, 421);
            this.ClassBox.MaxLength = 10;
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(392, 35);
            this.ClassBox.TabIndex = 18;
            this.ClassBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClassBox_HelpRequested);
            // 
            // ClassCheck
            // 
            this.ClassCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.ClassCheck.AutoSize = true;
            this.ClassCheck.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCheck.Location = new System.Drawing.Point(13, 418);
            this.ClassCheck.Name = "ClassCheck";
            this.ClassCheck.Size = new System.Drawing.Size(128, 39);
            this.ClassCheck.TabIndex = 17;
            this.ClassCheck.Text = " Class:";
            this.ClassCheck.UseVisualStyleBackColor = true;
            this.ClassCheck.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ClassCheck_HelpRequested);
            // 
            // ResultsBox
            // 
            this.ResultsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResultsBox.Font = new System.Drawing.Font("SF Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ResultsBox.Location = new System.Drawing.Point(546, 12);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.Size = new System.Drawing.Size(519, 886);
            this.ResultsBox.TabIndex = 19;
            this.ResultsBox.Text = "";
            this.ResultsBox.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ResultsBox_HelpRequested);
            // 
            // HTMLSaveDialog
            // 
            this.HTMLSaveDialog.FileName = "ResultHTML";
            this.HTMLSaveDialog.Filter = "HTML File(*.html) | *.html";
            this.HTMLSaveDialog.Title = "Choose saving location:";
            // 
            // TaxiFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1077, 971);
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
            this.Font = new System.Drawing.Font("SF Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaxiFinderForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TaxiFinder";
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


namespace CurrencyConverter
{
    partial class Convert
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert));
            panelMenu = new Panel();
            chartButton = new Button();
            convertButton1 = new Button();
            panelLogo = new Panel();
            label4 = new Label();
            label3 = new Label();
            comboBoxFrom = new ComboBox();
            convertButton = new Button();
            amountBox = new TextBox();
            comboBoxTo = new ComboBox();
            buttonSwap = new Button();
            labelAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            conversionRateDisplay = new Label();
            convertedAmountDisplay = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.GradientInactiveCaption;
            panelMenu.Controls.Add(chartButton);
            panelMenu.Controls.Add(convertButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(517, 64);
            panelMenu.TabIndex = 0;
            // 
            // chartButton
            // 
            chartButton.Dock = DockStyle.Left;
            chartButton.FlatAppearance.BorderSize = 0;
            chartButton.FlatStyle = FlatStyle.Flat;
            chartButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartButton.Image = (Image)resources.GetObject("chartButton.Image");
            chartButton.ImageAlign = ContentAlignment.MiddleLeft;
            chartButton.Location = new Point(357, 0);
            chartButton.Name = "chartButton";
            chartButton.RightToLeft = RightToLeft.No;
            chartButton.Size = new Size(160, 64);
            chartButton.TabIndex = 2;
            chartButton.Text = "Chart";
            chartButton.UseVisualStyleBackColor = true;
            chartButton.Click += this.chartButton_Click;
            // 
            // convertButton1
            // 
            convertButton1.Dock = DockStyle.Left;
            convertButton1.FlatAppearance.BorderSize = 0;
            convertButton1.FlatStyle = FlatStyle.Flat;
            convertButton1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertButton1.Image = (Image)resources.GetObject("convertButton1.Image");
            convertButton1.ImageAlign = ContentAlignment.MiddleLeft;
            convertButton1.Location = new Point(194, 0);
            convertButton1.Name = "convertButton1";
            convertButton1.Size = new Size(163, 64);
            convertButton1.TabIndex = 1;
            convertButton1.Text = "Convert";
            convertButton1.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ActiveCaption;
            panelLogo.Controls.Add(label4);
            panelLogo.Controls.Add(label3);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(194, 64);
            panelLogo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 33);
            label4.Name = "label4";
            label4.Size = new Size(160, 19);
            label4.TabIndex = 1;
            label4.Text = "Currency Converter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 0;
            label3.Text = "Pacs";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.BackColor = SystemColors.Window;
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrom.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFrom.ForeColor = SystemColors.WindowText;
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Items.AddRange(new object[] { "USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD", "MXN", "SGD", "HKD", "NOK", "KRW", "TRY", "RUB", "INR", "BRL", "ZAR", "PLN", "DKK", "THB", "IDR", "HUF", "CZK", "ILS", "CLP", "PHP", "AED", "COP", "SAR", "MYR", "RON" });
            comboBoxFrom.Location = new Point(200, 108);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(130, 32);
            comboBoxFrom.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.BackColor = SystemColors.Highlight;
            convertButton.FlatAppearance.BorderSize = 0;
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            convertButton.ForeColor = SystemColors.Control;
            convertButton.Location = new Point(375, 241);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(130, 43);
            convertButton.TabIndex = 2;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = false;
            convertButton.Click += convertButton_Click;
            // 
            // amountBox
            // 
            amountBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            amountBox.Location = new Point(12, 108);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(182, 32);
            amountBox.TabIndex = 3;
            amountBox.Text = "$1.00";
            // 
            // comboBoxTo
            // 
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTo.ForeColor = SystemColors.WindowText;
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Items.AddRange(new object[] { "USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD", "MXN", "SGD", "HKD", "NOK", "KRW", "TRY", "RUB", "INR", "BRL", "ZAR", "PLN", "DKK", "THB", "IDR", "HUF", "CZK", "ILS", "CLP", "PHP", "AED", "COP", "SAR", "MYR", "RON" });
            comboBoxTo.Location = new Point(375, 108);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(130, 32);
            comboBoxTo.TabIndex = 4;
            // 
            // buttonSwap
            // 
            buttonSwap.FlatAppearance.BorderSize = 0;
            buttonSwap.FlatStyle = FlatStyle.Flat;
            buttonSwap.Image = (Image)resources.GetObject("buttonSwap.Image");
            buttonSwap.Location = new Point(336, 108);
            buttonSwap.Name = "buttonSwap";
            buttonSwap.Size = new Size(33, 32);
            buttonSwap.TabIndex = 5;
            buttonSwap.UseVisualStyleBackColor = true;
            buttonSwap.Click += buttonSwap_Click;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmount.Location = new Point(12, 86);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(69, 19);
            labelAmount.TabIndex = 6;
            labelAmount.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 7;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(375, 86);
            label2.Name = "label2";
            label2.Size = new Size(28, 19);
            label2.TabIndex = 8;
            label2.Text = "To";
            // 
            // conversionRateDisplay
            // 
            conversionRateDisplay.AutoSize = true;
            conversionRateDisplay.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            conversionRateDisplay.Location = new Point(12, 177);
            conversionRateDisplay.Name = "conversionRateDisplay";
            conversionRateDisplay.Size = new Size(12, 18);
            conversionRateDisplay.TabIndex = 9;
            conversionRateDisplay.Text = " ";
            // 
            // convertedAmountDisplay
            // 
            convertedAmountDisplay.AutoSize = true;
            convertedAmountDisplay.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            convertedAmountDisplay.Location = new Point(12, 204);
            convertedAmountDisplay.Name = "convertedAmountDisplay";
            convertedAmountDisplay.Size = new Size(16, 24);
            convertedAmountDisplay.TabIndex = 10;
            convertedAmountDisplay.Text = " ";
            // 
            // Convert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(517, 296);
            Controls.Add(convertedAmountDisplay);
            Controls.Add(conversionRateDisplay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAmount);
            Controls.Add(buttonSwap);
            Controls.Add(comboBoxTo);
            Controls.Add(amountBox);
            Controls.Add(convertButton);
            Controls.Add(comboBoxFrom);
            Controls.Add(panelMenu);
            Name = "Convert";
            Text = "Currency Converter";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button convertButton1;
        private Button chartButton;
        private ComboBox comboBoxFrom;
        private Button convertButton;
        private TextBox amountBox;
        private ComboBox comboBoxTo;
        private Button buttonSwap;
        private Label labelAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label conversionRateDisplay;
        private Label convertedAmountDisplay;
    }
}

namespace CurrencyConverter
{
    partial class Chart
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            label2 = new Label();
            label1 = new Label();
            buttonSwap = new Button();
            comboBoxTo = new ComboBox();
            viewButton = new Button();
            comboBoxFrom = new ComboBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 49);
            label2.Name = "label2";
            label2.Size = new Size(28, 19);
            label2.TabIndex = 14;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 13;
            label1.Text = "From";
            // 
            // buttonSwap
            // 
            buttonSwap.FlatAppearance.BorderSize = 0;
            buttonSwap.FlatStyle = FlatStyle.Flat;
            buttonSwap.Image = (Image)resources.GetObject("buttonSwap.Image");
            buttonSwap.Location = new Point(282, 71);
            buttonSwap.Name = "buttonSwap";
            buttonSwap.Size = new Size(33, 32);
            buttonSwap.TabIndex = 12;
            buttonSwap.UseVisualStyleBackColor = true;
            buttonSwap.Click += buttonSwap_Click;
            // 
            // comboBoxTo
            // 
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTo.ForeColor = SystemColors.WindowText;
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Items.AddRange(new object[] { "USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD", "MXN", "SGD", "HKD", "NOK", "KRW", "TRY", "RUB", "INR", "BRL", "ZAR", "PLN", "DKK", "THB", "IDR", "HUF", "CZK", "ILS", "CLP", "PHP", "AED", "COP", "SAR", "MYR", "RON" });
            comboBoxTo.Location = new Point(321, 71);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(288, 32);
            comboBoxTo.TabIndex = 11;
            comboBoxTo.SelectedIndexChanged += comboBoxTo_SelectedIndexChanged;
            // 
            // viewButton
            // 
            viewButton.BackColor = SystemColors.Highlight;
            viewButton.FlatAppearance.BorderSize = 0;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewButton.ForeColor = SystemColors.Control;
            viewButton.Location = new Point(479, 118);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(130, 43);
            viewButton.TabIndex = 10;
            viewButton.Text = "View Chart";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += viewButton_Click;
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.BackColor = SystemColors.Window;
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrom.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFrom.ForeColor = SystemColors.WindowText;
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Items.AddRange(new object[] { "USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD", "MXN", "SGD", "HKD", "NOK", "KRW", "TRY", "RUB", "INR", "BRL", "ZAR", "PLN", "DKK", "THB", "IDR", "HUF", "CZK", "ILS", "CLP", "PHP", "AED", "COP", "SAR", "MYR", "RON" });
            comboBoxFrom.Location = new Point(12, 71);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(264, 32);
            comboBoxFrom.TabIndex = 9;
            comboBoxFrom.SelectedIndexChanged += comboBoxFrom_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 440);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(621, 10);
            progressBar1.TabIndex = 15;
            // 
            // Chart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSwap);
            Controls.Add(comboBoxTo);
            Controls.Add(viewButton);
            Controls.Add(comboBoxFrom);
            Name = "Chart";
            Text = "Chart";
            Load += Chart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button buttonSwap;
        private ComboBox comboBoxTo;
        private Button viewButton;
        private ComboBox comboBoxFrom;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
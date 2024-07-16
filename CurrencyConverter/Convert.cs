using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            // Swap the selected items of the two ComboBoxes
            object temp = comboBoxFrom.SelectedItem;
            comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTo.SelectedItem = "USD";
            comboBoxFrom.SelectedItem = "EUR";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://api.exchangerate-api.com/v4/latest/{fromCurrency}");
            }

            var data = JObject.Parse(json);
            if (data["rates"][toCurrency] == null)
            {
                throw new Exception($"Exchange rate for {toCurrency} not found.");
            }

            var rate = (double)data["rates"][toCurrency];
            return rate;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string fromCurrency = comboBoxFrom.SelectedItem.ToString();
            string toCurrency = comboBoxTo.SelectedItem.ToString();

            if (!double.TryParse(amountBox.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount to convert.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the exchange rate: {ex.Message}", "Error - API Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;
            convertedAmountDisplay.Text = $"{toCurrency} {convertedAmount:F2}";
            conversionRateDisplay.Text = $"1 {fromCurrency} = {exchangeRate:F4} {toCurrency}";
        }
        private void chartButton_Click( object sender, EventArgs e)
        {
            // Create an instance of the ChartForm
            Chart chartForm = new Chart();

            // Show the form
            chartForm.Show();
        }
    }
}

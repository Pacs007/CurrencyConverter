using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CurrencyConverter
{
    public partial class Chart : Form
    {
        private const int TimerInterval = 100; // Interval in milliseconds
        private const int TotalTime = 10000; // Total time in milliseconds (10 seconds)
        private int currentTime = 0;
        private bool timerRunning = false;

        public Chart()
        {
            InitializeComponent();

            // Initialize progress bar
            progressBar1.Maximum = TotalTime / TimerInterval;

            // Initialize timer
            timer1.Interval = TimerInterval;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currentTime += TimerInterval;

            // Update progress bar
            progressBar1.Value = currentTime / TimerInterval;

            // Check if time is up
            if (currentTime >= TotalTime)
            {
                // Reset progress bar and timer
                currentTime = 0;
                progressBar1.Value = 0;

                // Stop the timer
                timer1.Stop();
                timerRunning = false;
            }
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            // Swap the selected items of the two ComboBoxes
            object temp = comboBoxFrom.SelectedItem;
            comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = temp;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            // Start the timer only if it's not already running
            if (!timerRunning)
            {
                timer1.Start();
                timerRunning = true;
            }
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            currentTime = 0;
            progressBar1.Value = 0;
            timerRunning = false;
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            currentTime = 0;
            progressBar1.Value = 0;
            timerRunning = false;
        }
    }
}

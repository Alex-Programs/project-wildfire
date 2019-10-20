using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gui_App
{
    public partial class Form1 : Form
    {
        protected static int DataTableRowNumber = 1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Ember";
            this.FetchData();
            //label16.text = "Preparing to fetch data";
        }

        async void FetchData()
        {
            await Api.Fetch();
            foreach (var i in Api.ApiData.Values)
            {
                this.createTableRow(i);
            }
            Debug.WriteLine("Sent create signal");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Settings
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(255, 0, 0);


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        public void createTableRow(Wildfire ThisWildfire)
        {

            //sets table values
            //note: skipping day/night, version,
            Debug.WriteLine("Received, adding now");
            createTableColumn(DataTableRowNumber, 0, ThisWildfire.latitude);
            createTableColumn(DataTableRowNumber, 1, ThisWildfire.longitude);
            createTableColumn(DataTableRowNumber, 2, ThisWildfire.scan);
            createTableColumn(DataTableRowNumber, 3, ThisWildfire.track);
            createTableColumn(DataTableRowNumber, 4, ThisWildfire.acq_date);
            createTableColumn(DataTableRowNumber, 5, ThisWildfire.acq_time);
            createTableColumn(DataTableRowNumber, 6, ThisWildfire.confidence);
            createTableColumn(DataTableRowNumber, 7, ThisWildfire.version);
            createTableColumn(DataTableRowNumber, 8, ThisWildfire.bright_t31);
            createTableColumn(DataTableRowNumber, 9, ThisWildfire.frp);

            Debug.WriteLine("Added");

            // Increment the row number...
            DataTableRowNumber = DataTableRowNumber + 1;
            Debug.WriteLine($"DataTableRowNumber {DataTableRowNumber}");
        }

        public void createTableColumn(int RowNumber, int ColNumber, string ColumnValue)
        {
            Debug.WriteLine("Creating table column...");
            Label newTableLabel = new Label();
            newTableLabel.Text = ColumnValue;
            tableLayoutPanel1.Controls.Add(newTableLabel, ColNumber, RowNumber);
            Debug.WriteLine("Created table column.");
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //note: skipping day/night, version, 
        }
    }
}

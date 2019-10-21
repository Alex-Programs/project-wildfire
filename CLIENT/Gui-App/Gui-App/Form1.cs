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
            this.Text = "Ember Client Program";
            pictureBox1.Visible = true;
            this.FetchData();
            
        }

        async void FetchData()
        {

            SetProgrammingStatus("Fetching Data");
            await Api.Fetch();

            foreach (var i in Api.ApiData.Values)
            {
                this.createTableRow(i);
                pictureBox1.Visible = false;
            }
            SetProgrammingStatus("Done!");
            



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
            createTableColumn(DataTableRowNumber, 0, DataTableRowNumber.ToString());
            createTableColumn(DataTableRowNumber, 1, ThisWildfire.latitude);
            createTableColumn(DataTableRowNumber, 2, ThisWildfire.longitude);
            createTableColumn(DataTableRowNumber, 3, ThisWildfire.scan);
            createTableColumn(DataTableRowNumber, 4, ThisWildfire.track);
            createTableColumn(DataTableRowNumber, 5, ThisWildfire.acq_date);
            createTableColumn(DataTableRowNumber, 6, ThisWildfire.acq_time);
            createTableColumn(DataTableRowNumber, 7, ThisWildfire.confidence);
            createTableColumn(DataTableRowNumber, 8, ThisWildfire.version);
            createTableColumn(DataTableRowNumber, 9, ThisWildfire.bright_t31);
            createTableColumn(DataTableRowNumber, 10, ThisWildfire.frp);

            // Increment the row number...
            DataTableRowNumber = DataTableRowNumber + 1;
        }

        public void createTableColumn(int RowNumber, int ColNumber, string ColumnValue)
        {
            Label newTableLabel = new Label();
            newTableLabel.Text = ColumnValue;
            tableLayoutPanel1.Controls.Add(newTableLabel, ColNumber, RowNumber);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //note: skipping day/night, version, 
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        public void SetProgrammingStatus(string text)
        {
            label26.Text = text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Fetch(object sender, MouseEventArgs e)
        {
            //VS won't let us delete this without throwing a fit, is meant to be FetchData. Run by force update.
            //pictureBox1.Visible = true;
            //remove table info
            ShowMessage("This function is disabled pending further development", "Disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Disabled because I can't work out how to delete rows
            //FetchData();
        }

        public void ShowMessage(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ember";
            //label16.text = "Preparing to fetch data";
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

        public void setTable(string latitude, string longitude, string brightness, string scan, string track, string date, string time, string satellite, string confidence, string version, string brightness_t31, string FRP)
        {
            //sets table values
            //note: skipping day/night, version, 

            //tableLayoutPanel1.Controls.Add(new Label {latitude, longitude, brightness, scan, track, date, time, satellite, confidence, version, brightness_t31, FRP});

        }

        private void label14_Click(object sender, EventArgs e)
        {
            //note: skipping day/night, version, 
        }
    }
}

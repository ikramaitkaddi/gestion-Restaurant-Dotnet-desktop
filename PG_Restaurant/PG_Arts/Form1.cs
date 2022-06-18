
using PG_Arts.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n = Npgsql;

namespace PG_Arts
{
    public partial class Form1 : Form
    {
   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl31.Hide();
            userControl61.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
           
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.Show();
            userControl51.Hide();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl21.Show();

            userControl21.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            userControl51.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl41.BringToFront();
            userControl51.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Show();
            userControl51.BringToFront();
        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl31.Hide();
            userControl61.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
            login ob = new login();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 ob = new Form4();
            ob.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 ob = new Form5();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 ob = new Form3();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}

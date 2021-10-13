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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login ob = new login();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 ob = new Form2();
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
            this.Close();
            Form4 ob = new Form4();
            ob.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace banking
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string id = textBox1.Text;
            string pass = textBox2.Text;
            if (id == "admin" && pass == "admin")
            {
                this.Hide();
                home ob = new home();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Passward Worng");
            }


        }
    }
}

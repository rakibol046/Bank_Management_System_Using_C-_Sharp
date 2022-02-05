using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace banking
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            userInfo ob = new userInfo();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            allUserInfo ob = new allUserInfo();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            withdaw ob = new withdaw();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            deposit ob = new deposit();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            login ob = new login();
            ob.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            

            string accType = comboBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string date = dateTimePicker1.Text;
            string nName = textBox2.Text;
            int accBalance = Convert.ToInt32(textBox3.Text);
            if(accBalance > 50000)
            {
                MessageBox.Show("Debit Account max value is 100000!");
            }
            else if(accBalance<1000)
            {
                MessageBox.Show("Debit Account Min value is 1000 for new Account!");
            }
            else
            {
               
                SqlConnection connect = new SqlConnection("Data Source=LAPTOP-81VB06I4;Initial Catalog=banking;Integrated Security=True");
                
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[userinformation]
                                                               ([AccountType]
                                                               ,[Name]
                                                               ,[Date]
                                                               ,[NomineeName]
                                                               ,[Balance])
                                                     VALUES
                                                           ('" + accType + "', '"+ name + "','"+date+"' , '"+ nName + "', '"+ accBalance + "')", connect);
                                connect.Open();
                                cmd.ExecuteNonQuery();
                                connect.Close();
                                MessageBox.Show("Account Created Successfully ");


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banking
{
    public partial class allUserInfo : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-81VB06I4;Initial Catalog=banking;Integrated Security=True");
        public allUserInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home ob = new home();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            userInfo ob = new userInfo();
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

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display_data()
        {
            connect.Open();
            SqlCommand cmd =connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM userinformation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void allUserInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }
    }
}

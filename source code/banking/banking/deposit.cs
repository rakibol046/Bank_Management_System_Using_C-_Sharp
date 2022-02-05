using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace banking
{
    public partial class deposit : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-81VB06I4;Initial Catalog=banking;Integrated Security=True");
        public deposit()
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

        private void button6_Click(object sender, EventArgs e)
        {

            this.Close();
            login ob = new login();
            ob.Show();
        }

        public void Update(int x, int y)
        {
           
            string update_query = "UPDATE userinformation SET  Balance = '" + x + "' WHERE AccountNumber = '" + y + "'";
            SqlCommand cmnd = new SqlCommand(update_query, connect);
            cmnd.ExecuteNonQuery();

            MessageBox.Show("Deposit Successful \nnew balance is " + x.ToString());
            connect.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int enteredaccount = Convert.ToInt32(textBox1.Text);
            int dBalance = Convert.ToInt32(textBox2.Text);
            int sumbalance = 0;
            int balance = 0;

            connect.Open();
            string query = "Select * from userinformation Where AccountNumber = '" + enteredaccount + "'";
            
            SqlDataAdapter dt = new SqlDataAdapter(query, connect);
            DataTable dtbl = new DataTable();
            dt.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
               
             
                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                  string databasebalance = (data["Balance"].ToString());
                     balance = Convert.ToInt32(databasebalance);
                  
                     sumbalance = balance + dBalance;
        
                    data.Close();
                    Update(sumbalance, enteredaccount);
                }

            }
            else
            {
                MessageBox.Show("Invalid Account Number");
            }

            connect.Close();
        }
    }
}

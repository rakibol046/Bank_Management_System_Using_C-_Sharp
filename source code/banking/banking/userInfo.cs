using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace banking
{
    public partial class userInfo : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-81VB06I4;Initial Catalog=banking;Integrated Security=True");
        public userInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            home ob = new home();
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

        private void button7_Click(object sender, EventArgs e)
        {
            int enteredaccount = Convert.ToInt32(textBox1.Text);
            connect.Open();
            string query = "Select * from userinformation Where AccountNumber = '" + enteredaccount+"'";
            SqlDataAdapter dt = new SqlDataAdapter(query, connect);
            DataTable dtbl = new DataTable();
            dt.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                SqlCommand cmd = new SqlCommand(query, connect);
        
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read())
                {
                    name.Text = (data["Name"].ToString());
                    accountnumber.Text = (data["AccountNumber"].ToString());
                    accounttype.Text = (data["Accounttype"].ToString());
                    dateofbirth.Text = (data["Date"].ToString());
                    nomineename.Text = (data["NomineeName"].ToString());
                    balance.Text = (data["Balance"].ToString());
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

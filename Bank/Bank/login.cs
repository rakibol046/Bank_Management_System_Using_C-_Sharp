using System.Windows.Forms;

namespace Bank
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
      

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();
            this.Close();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
            this.Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Form4 ob = new Form4();
            ob.Show();
            this.Close();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form5 ob = new Form5();
            ob.Show();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

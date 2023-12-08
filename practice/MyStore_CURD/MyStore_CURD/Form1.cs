using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.Sql;

namespace MyStore_CURD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-60D1VQ1\\SQLEXPRESS2019;Initial Catalog=Mystore;Persist Security Info=True;User ID=sa;Password=India123;Encrypt=True;TrustServerCertificate=True");

            //Data Source=DESKTOP-60D1VQ1\SQLEXPRESS2019;Initial Catalog=Mystore;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True;Trust Server Certificate=True
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO productInfo_Tab VALUES ('" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", con);

            command.ExecuteNonQuery();// ExecuteNonQuery is used to insert and delete  the data in the data base
            MessageBox.Show("Successfully Inserted");
            con.Close();
        }
        void BiindData()
        {
            SqlConnection command = new SqlConnection("select * from productInfo_Tab");
            SqlDataAdapter sd = new SqlDataAdapter();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloDoc
{
    public partial class Login : Form
    {
        private static string _conStr = ConfigurationManager.ConnectionStrings["MedicalDbContext"].ToString();
        private static SqlConnection _con = new SqlConnection(_conStr);
        private SqlCommand _cmd = new SqlCommand("", _con);
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            string str = "SELECT name FROM employee WHERE password='" + textBox2.Text + "'";
            _cmd.CommandText = str;
            _con.Open();
            SqlDataReader dr;
            dr = _cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Home obj2 = new Home();
                obj2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username and Password.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

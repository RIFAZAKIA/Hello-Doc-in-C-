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
    public partial class NewPatient : Form
    {
        private static string _conStr = ConfigurationManager.ConnectionStrings["MedicalDbContext"].ToString();
        private static SqlConnection _con = new SqlConnection(_conStr);
        private SqlCommand _cmd = new SqlCommand("", _con);
        public NewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string str = " insert into patient values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'); ";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                string str1 = "select max(pat_id) from patient ;";
                _cmd.CommandText = str1;
                SqlDataReader dr = _cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Record saved Successfully. ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            _con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                string str = " insert into patient values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'); ";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                string str1 = "select max(pat_id) from patient ;";
                _cmd.CommandText = str1;
                SqlDataReader dr = _cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Record saved Successfully. ");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            _con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}

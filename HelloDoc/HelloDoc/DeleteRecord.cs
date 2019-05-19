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
    public partial class DeleteRecord : Form
    {
        private static string _conStr = ConfigurationManager.ConnectionStrings["MedicalDbContext"].ToString();
        private static SqlConnection _con = new SqlConnection(_conStr);
        private SqlCommand _cmd = new SqlCommand("", _con);
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Doctor")
            {

                string str = "DELETE FROM doctor WHERE doct_id = '" + textBox1.Text + "'";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Record Delete Successfully");
                _con.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Patient")
            {

                string str = "DELETE FROM patient WHERE pat_id = '" + textBox1.Text + "'";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Delete Successfully");
                _con.Close();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Doctor")
            {

                string str = "DELETE FROM doctor WHERE doct_id = '" + textBox1.Text + "'";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Record Delete Successfully");
                _con.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "Patient")
            {

                string str = "DELETE FROM patient WHERE pat_id = '" + textBox1.Text + "'";
                _cmd.CommandText = str;
                _con.Open();
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Record Delete Successfully");
                _con.Close();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

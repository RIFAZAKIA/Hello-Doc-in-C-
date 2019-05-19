using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloDoc
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecord obj4 = new DeleteRecord();
            obj4.ShowDialog();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient obj1 = new NewPatient();
            obj1.ShowDialog();
        }

        private void newDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDoctor obj2 = new NewDoctor();
            obj2.ShowDialog();
        }


        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

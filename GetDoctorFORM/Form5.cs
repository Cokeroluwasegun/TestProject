using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDoctorFORM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int n = Program.docManager.Doctors.Count;
            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string appoint = Program.docManager.Doctors[i].DoctorName;
                arr[i] = appoint;
            }
            comboBox1.DataSource = arr;


            int p = Program.docManager.patients.Count;
            string[] arr1 = new string[p];

            for (int i = 0; i < n; i++)
            {
                string appoint = Program.docManager.patients[i]._PatientName;
                arr[i] = appoint;
            }
            comboBox2.DataSource = arr;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 doc = new Form1();
            doc.Show();
            this.Hide();
        }

        private void appointmentBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dat
        }
    }
}

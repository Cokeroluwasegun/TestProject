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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {

            string Name = name.Text;
            string Age = age.Text;
            string BloodGroup = bloodgroup.Text;
            string Genotype = genotype.Text;
            string Location = plocation.Text;
            string Email = eMail.Text;
            string PhoneNumber = pnumber.Text;
            string gender = Convert.ToString(gender1.Text);


            Patient p = new Patient(Name, Age, gender, BloodGroup, Genotype, Location,Email,PhoneNumber);


            Program.docManager.AddPatient(p);

            dataGridV1.DataSource = null;

            dataGridV1.DataSource = Program.docManager.patients;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 doctorform = new Form1();
            doctorform.Show();
            this.Hide();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 patientform = new Form2();
            patientform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void appointmentBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 appoint = new Form5();
            appoint.Show();
            this.Hide();
        }
    }
}

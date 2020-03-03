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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            
            string Name = name.Text;
            string Age = age.Text;
            string Gender =Convert.ToString (gender.Text);
            string Qualification = qualification.Text;
            int Experience = int.Parse(experience.Text);
            string Specilization = specilization.Text;
            string Location = location.Text;
            string Mail = mail.Text;
            string Number = number.Text;

           

            //create object of Doctor class

            Doctor d = new Doctor(Name, Age, Gender, Qualification, Experience, Specilization,Location, Mail,  Number);

            //object for Doctor manager class

            
            Program.docManager.AddDoctor(d);
            dataGridV.DataSource = null;

            dataGridV.DataSource = Program.docManager.Doctors;


        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Information.DataSource = Doctors();

        }

        private void gender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void appointmentBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 appoint = new Form5();
            appoint.Show();
            this.Hide();
        }
    }
}

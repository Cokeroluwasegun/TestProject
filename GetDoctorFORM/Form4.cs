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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Form1 doctorform = new Form1();
            doctorform.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 doctorform = new Form1();
            //doctorform.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 patientform = new Form2();
            patientform.Show();
            this.Hide();
        }

        private void appointmentBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 appnt = new Form5();
            appnt.Show();
            this.Hide(); 
        }
    }
}

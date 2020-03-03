namespace GetDoctorFORM
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDoctor1 = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.DateTimePicker();
            this.gender2 = new System.Windows.Forms.RadioButton();
            this.gender1 = new System.Windows.Forms.RadioButton();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.eMail = new System.Windows.Forms.TextBox();
            this.plocation = new System.Windows.Forms.TextBox();
            this.genotype = new System.Windows.Forms.TextBox();
            this.bloodgroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridV1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDoctor1
            // 
            this.AddDoctor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDoctor1.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddDoctor1.Location = new System.Drawing.Point(401, 487);
            this.AddDoctor1.Margin = new System.Windows.Forms.Padding(4);
            this.AddDoctor1.Name = "AddDoctor1";
            this.AddDoctor1.Size = new System.Drawing.Size(397, 52);
            this.AddDoctor1.TabIndex = 36;
            this.AddDoctor1.Text = "Create A Patient Profile";
            this.AddDoctor1.UseVisualStyleBackColor = true;
            this.AddDoctor1.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(401, 153);
            this.age.Margin = new System.Windows.Forms.Padding(4);
            this.age.MaxDate = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(247, 22);
            this.age.TabIndex = 35;
            this.age.Value = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.age.ValueChanged += new System.EventHandler(this.age_ValueChanged);
            // 
            // gender2
            // 
            this.gender2.AutoSize = true;
            this.gender2.Location = new System.Drawing.Point(604, 459);
            this.gender2.Margin = new System.Windows.Forms.Padding(4);
            this.gender2.Name = "gender2";
            this.gender2.Size = new System.Drawing.Size(72, 20);
            this.gender2.TabIndex = 34;
            this.gender2.TabStop = true;
            this.gender2.Text = "Female";
            this.gender2.UseVisualStyleBackColor = true;
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Location = new System.Drawing.Point(421, 459);
            this.gender1.Margin = new System.Windows.Forms.Padding(4);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(56, 20);
            this.gender1.TabIndex = 33;
            this.gender1.TabStop = true;
            this.gender1.Text = "Male";
            this.gender1.UseVisualStyleBackColor = true;
            // 
            // pnumber
            // 
            this.pnumber.Location = new System.Drawing.Point(401, 407);
            this.pnumber.Margin = new System.Windows.Forms.Padding(4);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(396, 22);
            this.pnumber.TabIndex = 32;
            // 
            // eMail
            // 
            this.eMail.Location = new System.Drawing.Point(401, 352);
            this.eMail.Margin = new System.Windows.Forms.Padding(4);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(396, 22);
            this.eMail.TabIndex = 31;
            // 
            // plocation
            // 
            this.plocation.Location = new System.Drawing.Point(401, 298);
            this.plocation.Margin = new System.Windows.Forms.Padding(4);
            this.plocation.Name = "plocation";
            this.plocation.Size = new System.Drawing.Size(396, 22);
            this.plocation.TabIndex = 30;
            // 
            // genotype
            // 
            this.genotype.Location = new System.Drawing.Point(401, 249);
            this.genotype.Margin = new System.Windows.Forms.Padding(4);
            this.genotype.Name = "genotype";
            this.genotype.Size = new System.Drawing.Size(396, 22);
            this.genotype.TabIndex = 29;
            // 
            // bloodgroup
            // 
            this.bloodgroup.Location = new System.Drawing.Point(401, 197);
            this.bloodgroup.Margin = new System.Windows.Forms.Padding(4);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(396, 22);
            this.bloodgroup.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Location";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Patient Registration Form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Genotype";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Blood Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date of Birth";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(401, 103);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(396, 22);
            this.name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.appointmentBookingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip2.TabIndex = 38;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // appointmentBookingToolStripMenuItem
            // 
            this.appointmentBookingToolStripMenuItem.Name = "appointmentBookingToolStripMenuItem";
            this.appointmentBookingToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.appointmentBookingToolStripMenuItem.Text = "Appointment Booking";
            this.appointmentBookingToolStripMenuItem.Click += new System.EventHandler(this.appointmentBookingToolStripMenuItem_Click);
            // 
            // dataGridV1
            // 
            this.dataGridV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV1.Location = new System.Drawing.Point(807, 230);
            this.dataGridV1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridV1.Name = "dataGridV1";
            this.dataGridV1.Size = new System.Drawing.Size(285, 94);
            this.dataGridV1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 459);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Gender";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridV1);
            this.Controls.Add(this.AddDoctor1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender2);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.plocation);
            this.Controls.Add(this.genotype);
            this.Controls.Add(this.bloodgroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDoctor1;
        private System.Windows.Forms.DateTimePicker age;
        private System.Windows.Forms.RadioButton gender2;
        private System.Windows.Forms.RadioButton gender1;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.TextBox eMail;
        private System.Windows.Forms.TextBox plocation;
        private System.Windows.Forms.TextBox genotype;
        private System.Windows.Forms.TextBox bloodgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentBookingToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridV1;
        private System.Windows.Forms.Label label9;
    }
}
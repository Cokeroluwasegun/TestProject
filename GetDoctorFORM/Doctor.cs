using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoctorFORM
{
   
    //create an interface to manage all method
    interface IDoctorManager
    {
        bool AddDoctor(Doctor d);
        bool RemoveDoctor(Doctor d);
        bool UpdateResult(Doctor d);
        bool AddPatient(Patient p);
        bool RemoveDoctor(Patient p);
        bool UpdateResult(Patient p);
        bool BookAppointment(Appoint a);

    }
    //create a class to inherit and implent the methods
    class DoctorManager : IDoctorManager
    {
        //create a list collection for Doctor and patient
         public List<Doctor> Doctors = new List<Doctor>();
        public List<Patient> patients= new List<Patient>();
        public List<Appoint> appoints = new List<Appoint>(); 

        

        public bool AddDoctor(Doctor d)
        {
           
            //Add new item to list anytime this method is called
            Doctors.Add(d);
            return true;
        }

        public bool AddPatient(Patient p)
        {
            patients.Add(p);
            return true;
        }

        public bool RemoveDoctor(Doctor d)
        {
            Doctors.Remove(d);
            return true;

            
        }

        public bool RemoveDoctor(Patient p)
        {
            throw new NotImplementedException();
        }

        public bool UpdateResult(Doctor d)
        {
            throw new NotImplementedException();
        }

        public bool UpdateResult(Patient p)
        {
            throw new NotImplementedException();
        }
    }
    class Doctor
    {

        public string DoctorName { get; set; }
        public string DoctorAge { get; set; }
        public string DoctorGender { get; set; }
        public string DoctorQualification { get; set; }
        public int DoctorExperience { get; set; }
        public string DoctorSpecilization { get; set; }
        public string DoctorLocation { get; set; }
        public string DoctorMail { get; set; }
        public string DoctorNumber { get; set; }
        //create a constructor to initialize all the field atrribute
        public Doctor(string name, string age, string gender, string qualification, int experience, string specilization, string location, string mail, string number)
        {
            this.DoctorName = name;
            this.DoctorAge = age;
            this.DoctorGender = gender;
            this.DoctorQualification = qualification;
            this.DoctorExperience = experience;
            this.DoctorSpecilization = specilization;
            this.DoctorLocation = location;
            this.DoctorMail = mail;
            this.DoctorNumber = number;
        }
        }
    
    class Patient
    {
        public string _PatientName { get; set; }
        public string _PatientAge { get; set; }
        public string _PatientGender { get; set; }
        public string _PatientBloodGroup { get; set; }
        public string _PatientGenotype { get; set; }
        public string _PatientLocation { get; set; }
        public string _PatientMail { get; set; }
        public string _PatientNumber { get; set; }

        //create a constructor to initialize the field

        public Patient(string name, string age, string Gender,string bg,string G, string Location,string email, string phone)
        {
            this._PatientName = name;
            this._PatientAge = age;
            this._PatientGender = Gender;
            this._PatientBloodGroup = bg;
            this._PatientGenotype = G;
            this._PatientMail = email;
            this._PatientNumber = phone;
        }
    }
}

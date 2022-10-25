using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistrationSystem
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }
        Student s1;
        public StudentInfo(Student s)
        {
            s1 = s;
            InitializeComponent();
        }

        private void showInfoBtn_Click(object sender, EventArgs e)
        {
            DisplayStudentInfo();
        }
        public void DisplayStudentInfo() {

            idTxt.Text = s1.Id.ToString();
            FnameTxt.Text = s1.Firstname;
            LnameTxt.Text = s1.Lastname;
            StreetTxt.Text = s1.Address.Street;
            CityTxt.Text = s1.Address.City;
            StateTxt.Text = s1.Address.State;
            ZipTxt.Text = s1.Address.Zip.ToString();
            EmailTxt.Text = s1.Email;
            GpaTxt.Text = Math.Round(s1.Gpa,2).ToString();
        }

        private void viewScheduleBtn_Click(object sender, EventArgs e)
        {
            StudentSchedule scheduleForm = new StudentSchedule(s1);
            scheduleForm.Show();
            this.Hide();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSchedule scheduleForm = new StudentSchedule(s1);
            scheduleForm.Show();
            this.Hide();
        }
    }
}

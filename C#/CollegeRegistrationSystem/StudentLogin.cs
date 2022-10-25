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
    public partial class StudentLogin : Form
    {
        Student s1;
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            try
            {
                int studentId = int.Parse(studentIDTxt.Text);
                s1 = new Student();
                s1.SelectDB(studentId);
                int idDB = s1.Id;

                bool isValid = studentId == idDB;
                
                if (isValid && s1.Firstname.Length > 0)
                {
                    StudentInfo studentInfoForm = new StudentInfo(s1);
                    studentInfoForm.Show();
                }
                else
                {
                    studentIDTxt.Text = "";
                    MessageBox.Show("Incorrect Student ID","Invalid ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    studentIDTxt.Focus();
                }

            }
            catch ( FormatException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();  
            adminForm.Show();
            this.Hide();
        }

    }
}

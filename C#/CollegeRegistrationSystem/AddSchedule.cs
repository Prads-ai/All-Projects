using System;
using System.Collections;
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
    public partial class AddSchedule : Form
    {
        List<Student> studentList = new List<Student>();
        int count;
        public AddSchedule()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id, zip;
            string firstname,lastname,email, street,city, state;
            double gpa;
            
            try{

                id = int.Parse(txt_studentID.Text);
                firstname = txt_firstname.Text;
                lastname = txt_lastname.Text;
                email = txt_email.Text;
                street = txt_street.Text;
                city = txt_city.Text;
                state = txt_state.Text;
                zip = int.Parse(txt_zip.Text);
                gpa = double.Parse(txt_GPA.Text);

                // Create a student object
                Address addr = new Address(street, city, state, zip);
                MessageBox.Show(id.ToString());
                MessageBox.Show(firstname);
                Student s = new Student(id,firstname, lastname, addr, email, gpa);
                studentList.Add(s);
                s.InsertDB();

                // Create an array of student
                Student[] stuArr = studentList.ToArray();

                for (int i = 0; i < stuArr.Length; i++) {
                    // Create a new Listview 
                    ListViewItem list = new ListViewItem(stuArr[i].Id.ToString());
                    foreach (ColumnHeader header in lv_student.Columns) {
                   
                        list.SubItems.Add(stuArr[i].Firstname);
                        list.SubItems.Add(stuArr[i].Lastname);
                        list.SubItems.Add(stuArr[i].Email);
                        list.SubItems.Add(stuArr[i].Gpa.ToString());
                    }
                    lv_student.Items.Add(list);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCourseForm acF = new AddCourseForm();
            this.Hide();
            acF.Show();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm acF = new AddCourseForm();
            this.Hide();
            acF.Show();
        }
    }
}

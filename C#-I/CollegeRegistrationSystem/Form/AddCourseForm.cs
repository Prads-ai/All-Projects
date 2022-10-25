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
    public partial class AddCourseForm : Form
    {
        Course c = new Course();
        List<Course> courseList = new List<Course>();

        public AddCourseForm()
        {
            InitializeComponent();    
        }
        private void btn_addCourse_Click(object sender, EventArgs e)
        {
            string courseID, courseName, courseDescription;
            int creditHour;
            try
            {
                courseID = txt_courseID.Text;
                courseName = txt_courseName.Text;
                courseDescription = txt_courseDescription.Text;
                creditHour = int.Parse(txt_CreditHour.Text);

                c.CourseId = courseID;
                c.CourseName = courseName;
                c.CourseDescription = courseDescription;
                c.Credithour = creditHour;
                c.insertDB();
                courseList.Add(c);

                // Convert the list to an array
                Course[] cArr = courseList.ToArray();
                // Looping
                for (int i = 0; i < cArr.Length; i++) { 
                    // Create Listview
                    ListViewItem litems = new ListViewItem(cArr[i].CourseId,0);
                    foreach (ColumnHeader header in lv_course.Columns) {

                        litems.SubItems.Add(cArr[i].CourseName);
                        litems.SubItems.Add(cArr[i].CourseDescription);
                        litems.SubItems.Add(cArr[i].Credithour.ToString());
                    }
                    lv_course.Items.Add(litems);
                }
            }
            catch (FormatException ex) { 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

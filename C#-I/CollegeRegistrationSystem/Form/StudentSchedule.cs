using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistrationSystem
{
    public partial class StudentSchedule : Form
    {
        Student s1;
        int count = 0;

        BindingSource scheduleBindingSource = new BindingSource();
        public StudentSchedule()
        {
            InitializeComponent();
        }
        public StudentSchedule( Student s)
        {
            s1 = s;
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            
            Section[] sec1 = s1.schedule.courseList.ToArray();

            for (int i = 0; i < sec1.Length; i++)
            {
               ListViewItem list1 = new ListViewItem(sec1[i].Crn.ToString(), 0);
                System.Diagnostics.Debug.WriteLine(sec1[i].toString());
               foreach (ColumnHeader header in listView.Columns)
               {
                  list1.SubItems.Add(sec1[i].CourseId);
                  list1.SubItems.Add(sec1[i].TimeDay);
                  list1.SubItems.Add(sec1[i].RoomNo);
                  list1.SubItems.Add(sec1[i].Instructor.ToString());
               }
                listView.Items.Add(list1);
            }
            displayBtn.Enabled = false;
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo(s1);
            this.Hide();
            studentInfo.Show();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            Section[] section = s1.schedule.courseList.ToArray();
            scheduleBindingSource.DataSource = section;
            listBox1.DataSource = scheduleBindingSource;

            for (int i = 0; i < section.Length; i++) { 
                listBox1.DisplayMember = section[i].ToString();
                scheduleBindingSource.ResetBindings(false);
            }
        }
    }
}

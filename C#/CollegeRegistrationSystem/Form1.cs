using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CollegeRegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBtn_Click(object sender, EventArgs e)
        {
            Person person = new Person("Jennifer", "Watson", new Address("56 Peachtree St", "Atlanta", "GA", 31103), "jwatson@hotmail.com");
            person.display();
        }

        private void instructorBtn_Click(object sender, EventArgs e)
        {
            //Instructor instructor = new Instructor(1, "Frank", "Smith", new Address("120 State St.", "Chicago", "IL", 60989), "B601", "frank@yahoo.com");
            //instructor.display();
            
            //Using SelectDB
            
            //Instructor inst2;
            //inst2 = new Instructor();
            //inst2.SelectDB(2);
            //inst2.display();

            Instructor newInstructor = new Instructor(7,"Ronz","Ronald",new Address("120 State St.", "Chicago", "IL", 60989), "B601", "ronald@yahoo.com");
            newInstructor.insertDB();
            newInstructor.display();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            //Student student = new Student(1, "Jones", "Jones", new Address("200 Larue St.", "Denver", "CO", 89721), "larry@yahoo.com",3.5);
            //student.display();

            Student student2 = new Student();
            student2.SelectDB(2);
            student2.display();
        }

        private void addressBtn_Click(object sender, EventArgs e)
        {
            Address address = new Address("200 Larue St.", "Denver", "CO", 89721);
            address.Street = "100 Larue St.";
            address.display();

           
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            Course course = new Course("CIST 1021", "Java III", "Learn how to create applications Java APi", 4);
            course.display();
            // Using selectDb method
            Course c2;
            c2 = new Course();
            c2.SelectDB("CIST 1305");
            c2.display();
        }

        private void sectionBtn_Click(object sender, EventArgs e)
        {
            //Section section = new Section(30101, "CIST 2341", "MW1-5pm", "MW1-5pm",1);
            //section.display();

            Section section = new Section();
            section.SelectDB(30101);
            section.display();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            Schedule sch1;
            sch1 = new Schedule();
            sch1.add(new Section(30101, "CIST 2341", "MW1-5pm", "MW1-5pm", 1));
            sch1.add(new Section(30102, "CIST 2371", "MW6-10pm", "F1145",3));
            sch1.Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin studentForm = new StudentLogin();
            studentForm.ShowDialog();
        }
    }
}

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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string id = adminIDTxt.Text;
            string password = adminPassTxt.Text;

            Authentication(id, password);
        }
        // Method that check the admin credentials
        public void Authentication(string id, string password) {
            if (!id.Equals("Admin") || !password.Equals("123"))
            {
                MessageBox.Show("Invalid ID or Password","Invalid Credential",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                AddSchedule adminDashboardForm = new AddSchedule();
                this.Hide();
                adminDashboardForm.Show();
            }
        }

        private void studentFormBtn_Click(object sender, EventArgs e)
        {
            StudentLogin slog  = new StudentLogin();
            this.Hide();
            this.Show();
        }
    }
}

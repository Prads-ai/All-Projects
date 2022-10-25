namespace CollegeRegistrationSystem
{
    partial class Form1
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
            this.personBtn = new System.Windows.Forms.Button();
            this.instructorBtn = new System.Windows.Forms.Button();
            this.studentBtn = new System.Windows.Forms.Button();
            this.courseBtn = new System.Windows.Forms.Button();
            this.sectionBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personBtn
            // 
            this.personBtn.Location = new System.Drawing.Point(12, 12);
            this.personBtn.Name = "personBtn";
            this.personBtn.Size = new System.Drawing.Size(186, 63);
            this.personBtn.TabIndex = 0;
            this.personBtn.Text = "Person";
            this.personBtn.UseVisualStyleBackColor = true;
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click);
            // 
            // instructorBtn
            // 
            this.instructorBtn.Location = new System.Drawing.Point(12, 96);
            this.instructorBtn.Name = "instructorBtn";
            this.instructorBtn.Size = new System.Drawing.Size(186, 63);
            this.instructorBtn.TabIndex = 1;
            this.instructorBtn.Text = "Instructor";
            this.instructorBtn.UseVisualStyleBackColor = true;
            this.instructorBtn.Click += new System.EventHandler(this.instructorBtn_Click);
            // 
            // studentBtn
            // 
            this.studentBtn.Location = new System.Drawing.Point(12, 182);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(186, 63);
            this.studentBtn.TabIndex = 2;
            this.studentBtn.Text = "Student";
            this.studentBtn.UseVisualStyleBackColor = true;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // courseBtn
            // 
            this.courseBtn.Location = new System.Drawing.Point(247, 12);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(186, 63);
            this.courseBtn.TabIndex = 3;
            this.courseBtn.Text = "Course";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // sectionBtn
            // 
            this.sectionBtn.Location = new System.Drawing.Point(247, 96);
            this.sectionBtn.Name = "sectionBtn";
            this.sectionBtn.Size = new System.Drawing.Size(186, 63);
            this.sectionBtn.TabIndex = 4;
            this.sectionBtn.Text = "Section";
            this.sectionBtn.UseVisualStyleBackColor = true;
            this.sectionBtn.Click += new System.EventHandler(this.sectionBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(247, 182);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(186, 63);
            this.scheduleBtn.TabIndex = 5;
            this.scheduleBtn.Text = "Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // addressBtn
            // 
            this.addressBtn.Location = new System.Drawing.Point(12, 272);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(186, 63);
            this.addressBtn.TabIndex = 6;
            this.addressBtn.Text = "Address";
            this.addressBtn.UseVisualStyleBackColor = true;
            this.addressBtn.Click += new System.EventHandler(this.addressBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Student Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressBtn);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.sectionBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.studentBtn);
            this.Controls.Add(this.instructorBtn);
            this.Controls.Add(this.personBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personBtn;
        private System.Windows.Forms.Button instructorBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button sectionBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.Button button1;
    }
}


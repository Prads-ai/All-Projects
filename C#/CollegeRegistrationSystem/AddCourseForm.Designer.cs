namespace CollegeRegistrationSystem
{
    partial class AddCourseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_courseID = new System.Windows.Forms.TextBox();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.txt_courseDescription = new System.Windows.Forms.TextBox();
            this.txt_CreditHour = new System.Windows.Forms.TextBox();
            this.lv_course = new System.Windows.Forms.ListView();
            this.courseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CreditHour);
            this.groupBox1.Controls.Add(this.txt_courseDescription);
            this.groupBox1.Controls.Add(this.txt_courseName);
            this.groupBox1.Controls.Add(this.txt_courseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Credit Hour";
            // 
            // txt_courseID
            // 
            this.txt_courseID.Location = new System.Drawing.Point(157, 31);
            this.txt_courseID.Name = "txt_courseID";
            this.txt_courseID.Size = new System.Drawing.Size(212, 22);
            this.txt_courseID.TabIndex = 4;
            // 
            // txt_courseName
            // 
            this.txt_courseName.Location = new System.Drawing.Point(155, 68);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(212, 22);
            this.txt_courseName.TabIndex = 5;
            // 
            // txt_courseDescription
            // 
            this.txt_courseDescription.Location = new System.Drawing.Point(157, 114);
            this.txt_courseDescription.Name = "txt_courseDescription";
            this.txt_courseDescription.Size = new System.Drawing.Size(212, 22);
            this.txt_courseDescription.TabIndex = 6;
            // 
            // txt_CreditHour
            // 
            this.txt_CreditHour.Location = new System.Drawing.Point(157, 153);
            this.txt_CreditHour.Name = "txt_CreditHour";
            this.txt_CreditHour.Size = new System.Drawing.Size(212, 22);
            this.txt_CreditHour.TabIndex = 7;
            // 
            // lv_course
            // 
            this.lv_course.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseId,
            this.courseName,
            this.courseDescription,
            this.creditHour});
            this.lv_course.HideSelection = false;
            this.lv_course.Location = new System.Drawing.Point(465, 31);
            this.lv_course.Name = "lv_course";
            this.lv_course.Size = new System.Drawing.Size(528, 199);
            this.lv_course.TabIndex = 1;
            this.lv_course.UseCompatibleStateImageBehavior = false;
            this.lv_course.View = System.Windows.Forms.View.Details;
            // 
            // courseId
            // 
            this.courseId.Text = "Course ID";
            this.courseId.Width = 91;
            // 
            // courseName
            // 
            this.courseName.Text = "Course Name";
            this.courseName.Width = 118;
            // 
            // courseDescription
            // 
            this.courseDescription.Text = "Description";
            this.courseDescription.Width = 107;
            // 
            // creditHour
            // 
            this.creditHour.Text = "Credit Hour";
            this.creditHour.Width = 105;
            // 
            // btn_addCourse
            // 
            this.btn_addCourse.Location = new System.Drawing.Point(29, 236);
            this.btn_addCourse.Name = "btn_addCourse";
            this.btn_addCourse.Size = new System.Drawing.Size(111, 38);
            this.btn_addCourse.TabIndex = 2;
            this.btn_addCourse.Text = "Add Course";
            this.btn_addCourse.UseVisualStyleBackColor = true;
            this.btn_addCourse.Click += new System.EventHandler(this.btn_addCourse_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 315);
            this.Controls.Add(this.btn_addCourse);
            this.Controls.Add(this.lv_course);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CreditHour;
        private System.Windows.Forms.TextBox txt_courseDescription;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.TextBox txt_courseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_course;
        private System.Windows.Forms.ColumnHeader courseId;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader courseDescription;
        private System.Windows.Forms.ColumnHeader creditHour;
        private System.Windows.Forms.Button btn_addCourse;
    }
}
namespace CollegeRegistrationSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.adminIDTxt = new System.Windows.Forms.TextBox();
            this.adminID = new System.Windows.Forms.Label();
            this.adminPassLbl = new System.Windows.Forms.Label();
            this.adminPassTxt = new System.Windows.Forms.TextBox();
            this.studentFormBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(151, 244);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(213, 41);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // adminIDTxt
            // 
            this.adminIDTxt.Location = new System.Drawing.Point(254, 127);
            this.adminIDTxt.Name = "adminIDTxt";
            this.adminIDTxt.Size = new System.Drawing.Size(182, 22);
            this.adminIDTxt.TabIndex = 1;
            // 
            // adminID
            // 
            this.adminID.AutoSize = true;
            this.adminID.BackColor = System.Drawing.SystemColors.Control;
            this.adminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminID.Location = new System.Drawing.Point(75, 127);
            this.adminID.Name = "adminID";
            this.adminID.Size = new System.Drawing.Size(89, 22);
            this.adminID.TabIndex = 2;
            this.adminID.Text = "Admin Id :";
            // 
            // adminPassLbl
            // 
            this.adminPassLbl.AutoSize = true;
            this.adminPassLbl.BackColor = System.Drawing.SystemColors.Control;
            this.adminPassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPassLbl.Location = new System.Drawing.Point(75, 175);
            this.adminPassLbl.Name = "adminPassLbl";
            this.adminPassLbl.Size = new System.Drawing.Size(99, 22);
            this.adminPassLbl.TabIndex = 3;
            this.adminPassLbl.Text = "Password :";
            // 
            // adminPassTxt
            // 
            this.adminPassTxt.Location = new System.Drawing.Point(254, 177);
            this.adminPassTxt.Name = "adminPassTxt";
            this.adminPassTxt.Size = new System.Drawing.Size(182, 22);
            this.adminPassTxt.TabIndex = 4;
            // 
            // studentFormBtn
            // 
            this.studentFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentFormBtn.Location = new System.Drawing.Point(57, 305);
            this.studentFormBtn.Name = "studentFormBtn";
            this.studentFormBtn.Size = new System.Drawing.Size(403, 41);
            this.studentFormBtn.TabIndex = 5;
            this.studentFormBtn.Text = "Not an admin ? Login as a student";
            this.studentFormBtn.UseVisualStyleBackColor = true;
            this.studentFormBtn.Click += new System.EventHandler(this.studentFormBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentFormBtn);
            this.Controls.Add(this.adminPassTxt);
            this.Controls.Add(this.adminPassLbl);
            this.Controls.Add(this.adminID);
            this.Controls.Add(this.adminIDTxt);
            this.Controls.Add(this.loginBtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox adminIDTxt;
        private System.Windows.Forms.Label adminID;
        private System.Windows.Forms.Label adminPassLbl;
        private System.Windows.Forms.TextBox adminPassTxt;
        private System.Windows.Forms.Button studentFormBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
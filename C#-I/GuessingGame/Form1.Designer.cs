namespace GuessingGame
{
    partial class GuessingGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.cpuGuessLBL = new System.Windows.Forms.Label();
            this.userGuessIPT = new System.Windows.Forms.TextBox();
            this.totalAttemptLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(84, 259);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(154, 60);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "&Start Game";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // cpuGuessLBL
            // 
            this.cpuGuessLBL.AutoSize = true;
            this.cpuGuessLBL.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuGuessLBL.Location = new System.Drawing.Point(160, 96);
            this.cpuGuessLBL.Name = "cpuGuessLBL";
            this.cpuGuessLBL.Size = new System.Drawing.Size(266, 18);
            this.cpuGuessLBL.TabIndex = 2;
            this.cpuGuessLBL.Text = "Can you guess the cpu \'s number";
            // 
            // userGuessIPT
            // 
            this.userGuessIPT.Enabled = false;
            this.userGuessIPT.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userGuessIPT.Location = new System.Drawing.Point(176, 182);
            this.userGuessIPT.Name = "userGuessIPT";
            this.userGuessIPT.Size = new System.Drawing.Size(217, 26);
            this.userGuessIPT.TabIndex = 3;
            this.userGuessIPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // totalAttemptLbl
            // 
            this.totalAttemptLbl.AutoSize = true;
            this.totalAttemptLbl.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalAttemptLbl.Location = new System.Drawing.Point(37, 381);
            this.totalAttemptLbl.Name = "totalAttemptLbl";
            this.totalAttemptLbl.Size = new System.Drawing.Size(167, 18);
            this.totalAttemptLbl.TabIndex = 4;
            this.totalAttemptLbl.Text = "Total of attempt(s)";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(293, 259);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(154, 60);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.totalAttemptLbl);
            this.Controls.Add(this.userGuessIPT);
            this.Controls.Add(this.cpuGuessLBL);
            this.Controls.Add(this.startBtn);
            this.Name = "GuessingGame";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBtn;
        private TextBox userIpt;
        private Label cpuGuessLBL;
        private TextBox userGuessIPT;
        private Label totalAttemptLbl;
        private Button exitBtn;
    }
}
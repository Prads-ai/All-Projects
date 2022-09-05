namespace Price_is_Right_Wheel_Spin
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.player1LBL = new System.Windows.Forms.Label();
            this.wheelNumberLBL = new System.Windows.Forms.Label();
            this.player2LBL = new System.Windows.Forms.Label();
            this.player3LBL = new System.Windows.Forms.Label();
            this.gameInfoTxt = new System.Windows.Forms.Label();
            this.player1ScoreLBL = new System.Windows.Forms.Label();
            this.player2ScoreLBL = new System.Windows.Forms.Label();
            this.player3Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price-is-Right Wheel Spin.";
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(192, 365);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(252, 48);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // player1LBL
            // 
            this.player1LBL.AutoSize = true;
            this.player1LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1LBL.Location = new System.Drawing.Point(22, 215);
            this.player1LBL.Name = "player1LBL";
            this.player1LBL.Size = new System.Drawing.Size(111, 20);
            this.player1LBL.TabIndex = 2;
            this.player1LBL.Text = "Player 1  Spin :";
            // 
            // wheelNumberLBL
            // 
            this.wheelNumberLBL.AutoSize = true;
            this.wheelNumberLBL.Location = new System.Drawing.Point(12, 104);
            this.wheelNumberLBL.Name = "wheelNumberLBL";
            this.wheelNumberLBL.Size = new System.Drawing.Size(0, 20);
            this.wheelNumberLBL.TabIndex = 3;
            // 
            // player2LBL
            // 
            this.player2LBL.AutoSize = true;
            this.player2LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2LBL.Location = new System.Drawing.Point(22, 257);
            this.player2LBL.Name = "player2LBL";
            this.player2LBL.Size = new System.Drawing.Size(107, 20);
            this.player2LBL.TabIndex = 4;
            this.player2LBL.Text = "Player 2  Spin:";
            // 
            // player3LBL
            // 
            this.player3LBL.AutoSize = true;
            this.player3LBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player3LBL.Location = new System.Drawing.Point(22, 303);
            this.player3LBL.Name = "player3LBL";
            this.player3LBL.Size = new System.Drawing.Size(107, 20);
            this.player3LBL.TabIndex = 5;
            this.player3LBL.Text = "Player 3  Spin:";
            // 
            // gameInfoTxt
            // 
            this.gameInfoTxt.AutoSize = true;
            this.gameInfoTxt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameInfoTxt.ForeColor = System.Drawing.Color.Firebrick;
            this.gameInfoTxt.Location = new System.Drawing.Point(268, 153);
            this.gameInfoTxt.Name = "gameInfoTxt";
            this.gameInfoTxt.Size = new System.Drawing.Size(151, 22);
            this.gameInfoTxt.TabIndex = 6;
            this.gameInfoTxt.Text = "SPIN THE WHEEL";
            // 
            // player1ScoreLBL
            // 
            this.player1ScoreLBL.AutoSize = true;
            this.player1ScoreLBL.Location = new System.Drawing.Point(598, 231);
            this.player1ScoreLBL.Name = "player1ScoreLBL";
            this.player1ScoreLBL.Size = new System.Drawing.Size(46, 20);
            this.player1ScoreLBL.TabIndex = 7;
            this.player1ScoreLBL.Text = "Score";
            // 
            // player2ScoreLBL
            // 
            this.player2ScoreLBL.AutoSize = true;
            this.player2ScoreLBL.Location = new System.Drawing.Point(598, 267);
            this.player2ScoreLBL.Name = "player2ScoreLBL";
            this.player2ScoreLBL.Size = new System.Drawing.Size(46, 20);
            this.player2ScoreLBL.TabIndex = 8;
            this.player2ScoreLBL.Text = "Score";
            // 
            // player3Score
            // 
            this.player3Score.AutoSize = true;
            this.player3Score.Location = new System.Drawing.Point(598, 303);
            this.player3Score.Name = "player3Score";
            this.player3Score.Size = new System.Drawing.Size(46, 20);
            this.player3Score.TabIndex = 9;
            this.player3Score.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.player3Score);
            this.Controls.Add(this.player2ScoreLBL);
            this.Controls.Add(this.player1ScoreLBL);
            this.Controls.Add(this.gameInfoTxt);
            this.Controls.Add(this.player3LBL);
            this.Controls.Add(this.player2LBL);
            this.Controls.Add(this.wheelNumberLBL);
            this.Controls.Add(this.player1LBL);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price is right wheel spin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button playBtn;
        private Label player1LBL;
        private Label wheelNumberLBL;
        private Label player2LBL;
        private Label player3LBL;
        private Label gameInfoTxt;
        private Label player1ScoreLBL;
        private Label player2ScoreLBL;
        private Label player3Score;
    }
}
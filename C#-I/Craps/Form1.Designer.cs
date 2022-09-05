namespace Craps
{
    partial class crapFrm
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
            this.dice1Btn = new System.Windows.Forms.Button();
            this.dice2Btn = new System.Windows.Forms.Button();
            this.playGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dice1Btn
            // 
            this.dice1Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dice1Btn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dice1Btn.Location = new System.Drawing.Point(34, 137);
            this.dice1Btn.Name = "dice1Btn";
            this.dice1Btn.Size = new System.Drawing.Size(184, 146);
            this.dice1Btn.TabIndex = 0;
            this.dice1Btn.Text = "Dice 1";
            this.dice1Btn.UseVisualStyleBackColor = true;
            // 
            // dice2Btn
            // 
            this.dice2Btn.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dice2Btn.Location = new System.Drawing.Point(319, 137);
            this.dice2Btn.Name = "dice2Btn";
            this.dice2Btn.Size = new System.Drawing.Size(184, 146);
            this.dice2Btn.TabIndex = 1;
            this.dice2Btn.Text = "Dice 2";
            this.dice2Btn.UseVisualStyleBackColor = true;
            // 
            // playGameBtn
            // 
            this.playGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playGameBtn.Location = new System.Drawing.Point(153, 331);
            this.playGameBtn.Name = "playGameBtn";
            this.playGameBtn.Size = new System.Drawing.Size(227, 53);
            this.playGameBtn.TabIndex = 2;
            this.playGameBtn.Text = "Start Game";
            this.playGameBtn.UseVisualStyleBackColor = true;
            this.playGameBtn.Click += new System.EventHandler(this.playGameBtn_Click);
            // 
            // crapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 458);
            this.Controls.Add(this.playGameBtn);
            this.Controls.Add(this.dice2Btn);
            this.Controls.Add(this.dice1Btn);
            this.Name = "crapFrm";
            this.Text = "Crap Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Button dice1Btn;
        private Button dice2Btn;
        private Button playGameBtn;
    }
}
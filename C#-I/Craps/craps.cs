//=============================================================
//   Pradsley D'Haiti 
//   CIST2341: C# Programming I
//   Mini-Project : CRAPS
//=============================================================

namespace Craps
{
    public partial class crapFrm : Form
    {
        Random rand = new Random();
        Random rand2 = new Random();
        public crapFrm()
        {
            InitializeComponent();
        }

        private void playGameBtn_Click(object sender, EventArgs e)
        {
            PlayCraps();

        }
        void PlayCraps()
        {
            int point;
            int dice1 = rand.Next(11);
            int dice2 = rand2.Next(11);
            dice1Btn.Text = dice1.ToString();
            dice2Btn.Text = dice2.ToString();

            if (dice1 == 7 || dice2 == 7 || dice1 == 11 || dice2 == 11)
            {
                DialogResult dialog = MessageBox.Show("You Win !\n Do you want to continue", "Congratulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    Reset();
                    playGameBtn.Text = "Play Again";

                }
                else
                {
                    Reset();
                }

            }
            if (dice1 == 2 || dice2 == 2 || dice1 == 3 || dice2 == 3 || dice1 == 12 || dice2 == 12)
            {
                DialogResult dialog = MessageBox.Show("You Win !\n Do you want to continue", "Congratulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Reset();
                    playGameBtn.Text = "Play Again";
                    return;
                }
                else {
                    Reset();
                }

            }
            if (dice1 == 9 || dice2 == 9) {
                point = 9;
                while (true)
                {
                    if (dice1 == 9 || dice2 == 9)
                    {
                        Reset();
                        MessageBox.Show("You Win !", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    else if (dice1 == 7 || dice2 == 7)
                    {
                        Reset();
                        MessageBox.Show("You Lose !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                }

            }

        }
        void Reset() {
            dice1Btn.Text = "0";
            dice2Btn.Text = "0";
        }

        private void InitializeComponent1()
        {
            this.SuspendLayout();
            // 
            // crapFrm
            // 
            this.ClientSize = new System.Drawing.Size(519, 253);
            this.Name = "crapFrm";
            this.ResumeLayout(false);

        }
    }
}
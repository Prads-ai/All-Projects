//=============================================================
//   Pradsley D'Haiti 
//   CIST2341: C# Programming I
//   Project : PRICE_IS_RIGHT_WHEE_SPIN
//=============================================================


namespace Price_is_Right_Wheel_Spin
{
    public partial class Form1 : Form
    {
        // =================== PROGRAM VARIABLES =================================
        Random rand = new Random();
        int player1Total, player2Total, player3Total;
        int count = 1;
        string choice = "no";
        int[] scores = { 0, 0, 0 };
        int spin = 0;
        int luckyPlayer1, luckyPlayer2, luckyPlayer3 = 0;
        int winner = 0;
        // ====================== END OF PROGRAM VARIABLES ==============================
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSpin();
        }
        //Display to the players all the possible score the can get, when the spin the wheel.
        void ShowSpin()
        {
            for (int i = 1; i <= 20; i++)
            {
                int j = i * 5; // Multiply all the index values * 5 => ( 2 = 10 , 3 = 15);
                 wheelNumberLBL.Text += "[" + j + "]- "; 
            }
        }
      
        // Play Game
        async void PlayGame() {

            Player1Spin();

                if (count == 1)
                {
                    System.Media.SystemSounds.Question.Play();
                    DialogResult dialog = MessageBox.Show("Do you want to do another spin ?", "Hey Player 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    count++;
                    if (dialog == DialogResult.Yes)
                    {
                        Task.Delay(1000);
                        int player1score = Player1Spin(); // Generate another random spin for player 1.

                        if (player1score > 100)
                        {
                            player1ScoreLBL.ForeColor = Color.Red;
                            MessageBox.Show("Player 1 , your score is greater than 100, you are no longer part of the game", "Elimination ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            MessageBox.Show("Now it's player 2 to spin the wheel ", "Player 2's turn ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            player1LBL.Text = "Player 1 out of the game ";
                        }
                        else if (player1score == 100)
                        {
                        luckyPlayer1 = player1score;
                        MessageBox.Show("Great Job, you will have an additional spin when all the players are done spinning the wheel");
                        }
                }
                   
                }
                if (count == 2)
                {
                    MessageBox.Show("it's player 2 to spin the wheel, \n Press Ok to do your first spin ", "Player 2's turn ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Player2Spin();
                    System.Media.SystemSounds.Question.Play();
                    DialogResult dialog = MessageBox.Show("Do you want to do another spin ?", "Hey Player 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    count++;
                if (dialog == DialogResult.Yes)
                {
                    Task.Delay(1000);
                    int player2score = Player2Spin(); // Generate another random spin for player 1.

                    if (player2score > 100)
                    {
                        player2ScoreLBL.ForeColor = Color.Red;
                        MessageBox.Show("Player 2 , your score is greater than 100, you are no longer part of the game", "Elimination ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        MessageBox.Show("Now it's player 3 to spin the wheel ", "Player 3's turn ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        player2LBL.Text = "Player 2 out of the game ";
                    }
                    else if (player2score == 100) {
                            luckyPlayer2 = player2score;
                        MessageBox.Show("Great Job, you will have an additional spin when all the players are done spinning the wheel");
                    }

                }
                else {
                        MessageBox.Show("Now it's player 3 to spin the wheel, \n Press Ok to do your first spin ", "Player 3's turn ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Player3Spin();
                    }

                }
            if (count == 3) {

                MessageBox.Show("it's player 3 to spin the wheel, \n Press Ok to do your first spin ", "Player 3's turn ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Player3Spin();
                if (Player3Spin() > 100) {
                   player3Score.ForeColor = Color.Red;
                        player3LBL.Text = "Player 3 out of the game ";
                        MessageBox.Show("Player 3 , your score is greater than 100, you are no longer part of the game", "Elimination ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    MessageBox.Show("The winner is " + winner);

                    return;
                }
                else if (Player3Spin() == 100)
                {
                    luckyPlayer3 = Player3Spin();
                    
                    MessageBox.Show("Great Job, you will have an additional spin");

                }
                System.Media.SystemSounds.Question.Play();
                DialogResult dialog = MessageBox.Show("Do you want to do another spin? \n Press Ok to do so", "Hey Player 3", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    Player3Spin();
                }              

            }
            // =============================    DISPLAY WINNER ===============================================================
            winner = scores.Where(x => x <= 100).Max();
            for (int i = 0; i < scores.Length; i++) {
                if (scores[i] == winner) {
                    if (i == 0)
                    {
                        MessageBox.Show("Player 1 is the winner");
                        gameInfoTxt.Text = "Congratulation Player 1";
                        player1LBL.ForeColor = Color.Green;
                    }
                    else if (i == 1)
                    {
                        MessageBox.Show("Player 2 is the winner");
                        gameInfoTxt.Text = "Congratulation Player 2";
                        player2LBL.ForeColor = Color.Green;
                    }
                    else {
                        gameInfoTxt.Text = "Congratulation Player 3";
                        MessageBox.Show("Player 3 is the winner");
                        player3LBL.ForeColor = Color.Green;
                    }
                }
            }
            //============================= ADDITIONAL SPIN ================================================================================
            if (luckyPlayer1 > 0) {
                MessageBox.Show("Spin the wheel Player 1", "Extra chance");
                int luckyScore1 = Player1Spin();
                if (luckyScore1 == 100) {
                    MessageBox.Show("You have won an extra $25000");
                }
                DialogResult dialog2 = MessageBox.Show("Do you want to spin the wheel again", "Player 1 extra chance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog2 == DialogResult.Yes) {
                    luckyScore1 = Player1Spin();
                    if (luckyScore1 == 5 || luckyScore1 == 15)
                    {
                        MessageBox.Show("also won extra $15000");
                    }
                    else {
                        MessageBox.Show(" Did not won any extra amount");
                    }
                }
            }

            else if (luckyPlayer2 > 0)
            {
                MessageBox.Show("Spin the wheel Player 1", "Extra chance");
                int luckyScore2 = Player1Spin();
                if (luckyScore2 == 100)
                {
                    MessageBox.Show("You have won an extra $25000");
                }
                DialogResult dialog2 = MessageBox.Show("Do you want to spin the wheel again", "Player 1 extra chance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog2 == DialogResult.Yes)
                {
                    luckyScore2 = Player1Spin();
                    if (luckyScore2 == 5 || luckyScore2 == 15)
                    {
                        MessageBox.Show("also won extra $15000");
                    }
                    else
                    {
                        MessageBox.Show(" Did not won any extra amount");
                    }
                }
            }

            else if (luckyPlayer3 > 0)
            {
                MessageBox.Show("Spin the wheel Player 1", "Extra chance");
                int luckyScore3 = Player1Spin();
                if (luckyScore3 == 100)
                {
                    MessageBox.Show("You have won an extra $25000");
                }
                DialogResult dialog2 = MessageBox.Show("Do you want to spin the wheel again", "Player 1 extra chance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog2 == DialogResult.Yes)
                {
                    luckyScore3 = Player1Spin();
                    if (luckyScore3 == 5 || luckyScore3 == 15)
                    {
                        MessageBox.Show("also won extra $15000");
                    }
                    else
                    {
                        MessageBox.Show(" Did not won any extra amount");
                    }
                }
            }

            MessageBox.Show(" With a HighScore of  " + winner);
            playBtn.Enabled = false;
            count++;
            System.Diagnostics.Debug.WriteLine(count);
            }
          
            
        // Player 1 Turn
        int Player1Spin()
        {
            int wheelNumber = rand.Next(1, 20) * 5;
            spin = wheelNumber;
            scores[0] += spin;
            player1Total = scores[0];
            player1ScoreLBL.Text = "Score : " + player1Total;
            return player1Total;
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            PlayGame();
            playBtn.Text = "Spin";
        }

        // Player 2 Turn
        int Player2Spin()
        {
            int wheelNumber = 0;
            wheelNumber = rand.Next(1, 20) * 5;
            spin = wheelNumber;
            scores[1] += spin;
            player2Total = scores[1];
            player2ScoreLBL.Text = "Score : " + player2Total;
            return player2Total;
        }
        // Player 3 Turn
        int Player3Spin()
        {
            int wheelNumber = rand.Next(1, 20) * 5;
            spin = wheelNumber;
            scores[2] = spin;
            player3Total = scores[2];
            player3Score.Text = "Score : " + player3Total;
            return player3Total;
        }
       

    }
}
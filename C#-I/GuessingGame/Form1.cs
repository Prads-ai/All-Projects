namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        int cpuGuess;
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            userGuessIPT.Enabled = true;
            PlayGame();
            System.Diagnostics.Debug.WriteLine(PlayGame());
        }

        // Play Game 
        public  int  PlayGame() {
           
            Random rand = new Random();
            cpuGuess = rand.Next(1, 100);
            cpuGuessLBL.Text = "WHAT IS THE CPU'S GUESS NUMBER : " + cpuGuess;
            startBtn.Visible = false;
            userGuessIPT.Focus();
            System.Diagnostics.Debug.WriteLine(PlayGame());

            return cpuGuess;
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { 
                e.Handled = true;
            }
          
        }
    }
}